﻿namespace TextAdventures.Quest.EditorControls
{
    partial class WFAttributesControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctlSplitContainerMain = new System.Windows.Forms.SplitContainer();
            this.lstTypes = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctlTypesToolStrip = new System.Windows.Forms.ToolStrip();
            this.ToolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cmdAddType = new System.Windows.Forms.ToolStripButton();
            this.cmdDeleteType = new System.Windows.Forms.ToolStripButton();
            this.ctlSplitContainer = new System.Windows.Forms.SplitContainer();
            this.lstAttributes = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSource = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctlToolStrip = new System.Windows.Forms.ToolStrip();
            this.lblAttributesTitle = new System.Windows.Forms.ToolStripLabel();
            this.cmdAdd = new System.Windows.Forms.ToolStripButton();
            this.cmdDelete = new System.Windows.Forms.ToolStripButton();
            this.cmdOnChange = new System.Windows.Forms.ToolStripButton();
            this.ctlMultiControl = new TextAdventures.Quest.EditorControls.WFMultiControl();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ctlSplitContainerMain)).BeginInit();
            this.ctlSplitContainerMain.Panel1.SuspendLayout();
            this.ctlSplitContainerMain.Panel2.SuspendLayout();
            this.ctlSplitContainerMain.SuspendLayout();
            this.ctlTypesToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlSplitContainer)).BeginInit();
            this.ctlSplitContainer.Panel1.SuspendLayout();
            this.ctlSplitContainer.Panel2.SuspendLayout();
            this.ctlSplitContainer.SuspendLayout();
            this.ctlToolStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctlSplitContainerMain
            // 
            this.ctlSplitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlSplitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.ctlSplitContainerMain.Margin = new System.Windows.Forms.Padding(4);
            this.ctlSplitContainerMain.Name = "ctlSplitContainerMain";
            this.ctlSplitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ctlSplitContainerMain.Panel1
            // 
            this.ctlSplitContainerMain.Panel1.Controls.Add(this.lstTypes);
            this.ctlSplitContainerMain.Panel1.Controls.Add(this.ctlTypesToolStrip);
            // 
            // ctlSplitContainerMain.Panel2
            // 
            this.ctlSplitContainerMain.Panel2.Controls.Add(this.ctlSplitContainer);
            this.ctlSplitContainerMain.Size = new System.Drawing.Size(1620, 800);
            this.ctlSplitContainerMain.SplitterDistance = 175;
            this.ctlSplitContainerMain.SplitterIncrement = 50;
            this.ctlSplitContainerMain.SplitterWidth = 5;
            this.ctlSplitContainerMain.TabIndex = 0;
            // 
            // lstTypes
            // 
            this.lstTypes.BackColor = System.Drawing.Color.White;
            this.lstTypes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3});
            this.lstTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTypes.ForeColor = System.Drawing.Color.Black;
            this.lstTypes.FullRowSelect = true;
            this.lstTypes.GridLines = true;
            this.lstTypes.HideSelection = false;
            this.lstTypes.Location = new System.Drawing.Point(0, 25);
            this.lstTypes.Margin = new System.Windows.Forms.Padding(4);
            this.lstTypes.MultiSelect = false;
            this.lstTypes.Name = "lstTypes";
            this.lstTypes.Size = new System.Drawing.Size(1620, 150);
            this.lstTypes.TabIndex = 6;
            this.lstTypes.UseCompatibleStateImageBehavior = false;
            this.lstTypes.View = System.Windows.Forms.View.Details;
            this.lstTypes.SelectedIndexChanged += new System.EventHandler(this.lstTypes_SelectedIndexChanged);
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Name";
            this.ColumnHeader1.Width = 200;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Value";
            this.ColumnHeader2.Width = 300;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "Source";
            this.ColumnHeader3.Width = 100;
            // 
            // ctlTypesToolStrip
            // 
            this.ctlTypesToolStrip.BackColor = System.Drawing.Color.Transparent;
            this.ctlTypesToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ctlTypesToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctlTypesToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripLabel2,
            this.cmdAddType,
            this.cmdDeleteType});
            this.ctlTypesToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ctlTypesToolStrip.Name = "ctlTypesToolStrip";
            this.ctlTypesToolStrip.Size = new System.Drawing.Size(1620, 25);
            this.ctlTypesToolStrip.TabIndex = 5;
            this.ctlTypesToolStrip.Text = "ToolStrip1";
            // 
            // ToolStripLabel2
            // 
            this.ToolStripLabel2.AutoSize = false;
            this.ToolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripLabel2.Name = "ToolStripLabel2";
            this.ToolStripLabel2.Size = new System.Drawing.Size(150, 22);
            this.ToolStripLabel2.Text = "Inherited Types";
            this.ToolStripLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdAddType
            // 
            this.cmdAddType.Image = global::TextAdventures.Quest.EditorControls.Properties.Resources.icons8_Plus_16;
            this.cmdAddType.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdAddType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAddType.Name = "cmdAddType";
            this.cmdAddType.Size = new System.Drawing.Size(23, 22);
            this.cmdAddType.ToolTipText = "Add";
            this.cmdAddType.Click += new System.EventHandler(this.cmdAddType_Click);
            // 
            // cmdDeleteType
            // 
            this.cmdDeleteType.Image = global::TextAdventures.Quest.EditorControls.Properties.Resources.icons8_Minus_16;
            this.cmdDeleteType.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdDeleteType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdDeleteType.Name = "cmdDeleteType";
            this.cmdDeleteType.Size = new System.Drawing.Size(23, 22);
            this.cmdDeleteType.ToolTipText = "Delete";
            this.cmdDeleteType.Click += new System.EventHandler(this.cmdDeleteType_Click);
            // 
            // ctlSplitContainer
            // 
            this.ctlSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.ctlSplitContainer.Margin = new System.Windows.Forms.Padding(4);
            this.ctlSplitContainer.Name = "ctlSplitContainer";
            // 
            // ctlSplitContainer.Panel1
            // 
            this.ctlSplitContainer.Panel1.Controls.Add(this.lstAttributes);
            this.ctlSplitContainer.Panel1.Controls.Add(this.ctlToolStrip);
            // 
            // ctlSplitContainer.Panel2
            // 
            this.ctlSplitContainer.Panel2.Controls.Add(this.ctlMultiControl);
            this.ctlSplitContainer.Panel2.Controls.Add(this.toolStrip);
            this.ctlSplitContainer.Size = new System.Drawing.Size(1620, 620);
            this.ctlSplitContainer.SplitterDistance = 810;
            this.ctlSplitContainer.SplitterIncrement = 50;
            this.ctlSplitContainer.SplitterWidth = 5;
            this.ctlSplitContainer.TabIndex = 0;
            // 
            // lstAttributes
            // 
            this.lstAttributes.BackColor = System.Drawing.Color.White;
            this.lstAttributes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colValue,
            this.colSource});
            this.lstAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAttributes.ForeColor = System.Drawing.Color.Black;
            this.lstAttributes.FullRowSelect = true;
            this.lstAttributes.GridLines = true;
            this.lstAttributes.HideSelection = false;
            this.lstAttributes.Location = new System.Drawing.Point(0, 25);
            this.lstAttributes.Margin = new System.Windows.Forms.Padding(4);
            this.lstAttributes.MultiSelect = false;
            this.lstAttributes.Name = "lstAttributes";
            this.lstAttributes.Size = new System.Drawing.Size(810, 595);
            this.lstAttributes.TabIndex = 5;
            this.lstAttributes.UseCompatibleStateImageBehavior = false;
            this.lstAttributes.View = System.Windows.Forms.View.Details;
            this.lstAttributes.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstAttributes_ColumnClick);
            this.lstAttributes.SelectedIndexChanged += new System.EventHandler(this.lstAttributes_SelectedIndexChanged);
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 200;
            // 
            // colValue
            // 
            this.colValue.Text = "Value";
            this.colValue.Width = 300;
            // 
            // colSource
            // 
            this.colSource.Text = "Source";
            this.colSource.Width = 100;
            // 
            // ctlToolStrip
            // 
            this.ctlToolStrip.BackColor = System.Drawing.Color.Transparent;
            this.ctlToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ctlToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctlToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblAttributesTitle,
            this.cmdAdd,
            this.cmdDelete,
            this.cmdOnChange});
            this.ctlToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ctlToolStrip.Name = "ctlToolStrip";
            this.ctlToolStrip.Size = new System.Drawing.Size(810, 25);
            this.ctlToolStrip.TabIndex = 4;
            this.ctlToolStrip.Text = "ToolStrip1";
            // 
            // lblAttributesTitle
            // 
            this.lblAttributesTitle.AutoSize = false;
            this.lblAttributesTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttributesTitle.Name = "lblAttributesTitle";
            this.lblAttributesTitle.Size = new System.Drawing.Size(150, 22);
            this.lblAttributesTitle.Text = "Attributes";
            this.lblAttributesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdAdd
            // 
            this.cmdAdd.Image = global::TextAdventures.Quest.EditorControls.Properties.Resources.icons8_Plus_16;
            this.cmdAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(23, 22);
            this.cmdAdd.ToolTipText = "Add";
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Image = global::TextAdventures.Quest.EditorControls.Properties.Resources.icons8_Minus_16;
            this.cmdDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(23, 22);
            this.cmdDelete.ToolTipText = "Delete";
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdOnChange
            // 
            this.cmdOnChange.Image = global::TextAdventures.Quest.EditorControls.Properties.Resources.icons8_Joyent;
            this.cmdOnChange.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdOnChange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdOnChange.Name = "cmdOnChange";
            this.cmdOnChange.Size = new System.Drawing.Size(23, 22);
            this.cmdOnChange.ToolTipText = "Add Change Script";
            this.cmdOnChange.Click += new System.EventHandler(this.cmdOnChange_Click);
            // 
            // ctlMultiControl
            // 
            this.ctlMultiControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctlMultiControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlMultiControl.Location = new System.Drawing.Point(0, 25);
            this.ctlMultiControl.Margin = new System.Windows.Forms.Padding(5);
            this.ctlMultiControl.Name = "ctlMultiControl";
            this.ctlMultiControl.Padding = new System.Windows.Forms.Padding(5);
            this.ctlMultiControl.Size = new System.Drawing.Size(805, 595);
            this.ctlMultiControl.TabIndex = 0;
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(805, 25);
            this.toolStrip.TabIndex = 3;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(93, 22);
            this.toolStripLabel1.Text = "Assignment";
            // 
            // WFAttributesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctlSplitContainerMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WFAttributesControl";
            this.Size = new System.Drawing.Size(1620, 800);
            this.ctlSplitContainerMain.Panel1.ResumeLayout(false);
            this.ctlSplitContainerMain.Panel1.PerformLayout();
            this.ctlSplitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctlSplitContainerMain)).EndInit();
            this.ctlSplitContainerMain.ResumeLayout(false);
            this.ctlTypesToolStrip.ResumeLayout(false);
            this.ctlTypesToolStrip.PerformLayout();
            this.ctlSplitContainer.Panel1.ResumeLayout(false);
            this.ctlSplitContainer.Panel1.PerformLayout();
            this.ctlSplitContainer.Panel2.ResumeLayout(false);
            this.ctlSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlSplitContainer)).EndInit();
            this.ctlSplitContainer.ResumeLayout(false);
            this.ctlToolStrip.ResumeLayout(false);
            this.ctlToolStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ToolStrip ctlTypesToolStrip;
        internal System.Windows.Forms.ToolStripLabel ToolStripLabel2;
        internal System.Windows.Forms.ToolStripButton cmdDeleteType;
        internal System.Windows.Forms.ListView lstTypes;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.ToolStrip ctlToolStrip;
        internal System.Windows.Forms.ToolStripLabel lblAttributesTitle;
        internal System.Windows.Forms.ToolStripButton cmdAdd;
        internal System.Windows.Forms.ToolStripButton cmdDelete;
        internal System.Windows.Forms.ListView lstAttributes;
        internal System.Windows.Forms.ColumnHeader colName;
        internal System.Windows.Forms.ColumnHeader colValue;
        internal System.Windows.Forms.ColumnHeader colSource;
        private WFMultiControl ctlMultiControl;
        protected System.Windows.Forms.SplitContainer ctlSplitContainerMain;
        protected System.Windows.Forms.ToolStripButton cmdOnChange;
        protected System.Windows.Forms.SplitContainer ctlSplitContainer;
        private System.Windows.Forms.ToolStripButton cmdAddType;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}
