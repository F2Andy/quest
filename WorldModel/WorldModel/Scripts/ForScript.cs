﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AxeSoftware.Quest.Functions;

namespace AxeSoftware.Quest.Scripts
{
    public class ForScriptConstructor : IScriptConstructor
    {
        #region IScriptConstructor Members

        public string Keyword
        {
            get { return "for"; }
        }

        public IScript Create(string script, Element proc)
        {
            string afterExpr;
            string param = Utility.GetParameter(script, out afterExpr);
            string loop = Utility.GetScript(afterExpr);
            
            string[] parameters = Utility.SplitParameter(param).ToArray();
            if (parameters.Count() != 3)
            {
                throw new Exception(string.Format("'for' script should have 3 parameters: 'for ({0})'", param));
            }
            IScript loopScript = ScriptFactory.CreateScript(loop);

            return new ForScript(WorldModel, ScriptFactory, parameters[0], new Expression<int>(parameters[1], WorldModel), new Expression<int>(parameters[2], WorldModel), loopScript);
        }

        public IScriptFactory ScriptFactory { get; set; }

        public WorldModel WorldModel { get; set; }

        #endregion
    }

    public class ForScript : ScriptBase
    {
        private IFunction<int> m_from;
        private IFunction<int> m_to;
        private IScript m_loopScript;
        private string m_variable;
        private WorldModel m_worldModel;
        private IScriptFactory m_scriptFactory;

        public ForScript(WorldModel worldModel, IScriptFactory scriptFactory, string variable, IFunction<int> from, IFunction<int> to, IScript loopScript)
        {
            m_worldModel = worldModel;
            m_scriptFactory = scriptFactory;
            m_variable = variable;
            m_from = from;
            m_to = to;
            m_loopScript = loopScript;
        }

        public override void Execute(Context c)
        {
            int from = m_from.Execute(c);
            int to = m_to.Execute(c);
            int count;
            c.Parameters[m_variable] = 0;

            for (count = from; count <= to; count++)
            {
                c.Parameters[m_variable] = count;
                m_loopScript.Execute(c);
            }
        }

        public override string Save()
        {
            return SaveScript("for", m_loopScript, m_variable, m_from.Save(), m_to.Save());
        }

        public override string Keyword
        {
            get
            {
                return "for";
            }
        }

        public override object GetParameter(int index)
        {
            switch (index)
            {
                case 0:
                    return m_variable;
                case 1:
                    return m_from.Save();
                case 2:
                    return m_to.Save();
                case 3:
                    return m_loopScript;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public override void SetParameterInternal(int index, object value)
        {
            switch (index)
            {
                case 0:
                    m_variable = (string)value;
                    break;
                case 1:
                    m_from = new Expression<int>((string)value, m_worldModel);
                    break;
                case 2:
                    m_to = new Expression<int>((string)value, m_worldModel);
                    break;
                case 3:
                    // any updates to the script should change the script itself - nothing should cause SetParameter to be triggered.
                    throw new InvalidOperationException("Attempt to use SetParameter to change the script of a 'for' loop");
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
