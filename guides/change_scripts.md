---
layout: index
title: Using Change Scripts
---

A change script is a script linked to an attribute. The script runs whenever the attribute changes. It is most useful when you have an attribute that can change in several different situations, but in all of them, you want the same thing to happen. A good example is in an RPG-style game, where you want to check the player's hit points to see if he is dead. The hit points might change when the player is attacked, drinks a poison or sets off a trap. Each of those events can modify the hits, but you have one just one change script that checks if the player is alive.

Quest has some change scripts already built in. If you change the parent attribute of the player, a change script fires that calls the OnEnterRoom function. This ensures the function gets called every time, rather than replying on game creators calling it each time the player moves.

Change scripts can be created for attributes on any object, not just the player, by the way.

As an example, let us create an attribute called "hitpoints" on the player object. You can do that on the Attributes tab by clicking Add just above the bottom box. Set it to be an integer. Once it is in the list, click on it and then click the "Add Change Script" button. Quest will add a new attribute, "changedhitpoints". Easy as that.

Now make the script display the new hit points:

    msg ("Hits points now " + player.hitpoints)

Here is an example of a change script in action in action:

    <!--Saved by Quest 5.6.5621.18142-->
    <asl version="550">
      <include ref="English.aslx" />
      <include ref="Core.aslx" />
      <game name="test_change">
        <gameid>cd4d850f-af71-4e87-ba68-f97fb87284ee</gameid>
        <version>1.0</version>
        <firstpublished>2015</firstpublished>
      </game>
      <object name="room">
        <inherit name="editor_room" />
        <description>Type "drink poison" to see the change script in action!</description>
        <object name="player">
          <inherit name="editor_object" />
          <inherit name="editor_player" />
          <hitpoints type="int">55</hitpoints>
          <changedhitpoints type="script"><![CDATA[
            if (player.hitpoints > 0) {
              msg ("Hits points now " + player.hitpoints)
            }
            else {
              msg ("You died!!!")
              finish
            }
          ]]></changedhitpoints>
        </object>
      </object>
      <command name="poison">
        <pattern>drink poison</pattern>
        <script>
          player.hitpoints = player.hitpoints - 10
        </script>
      </command>
    </asl>

Quest recognises an attribute as a change script if it is a script and its name starts with "changed". They are just standard scripts, and you can use them as such:

    do (player, "changedhitpoints")


Lists
-----

Changing the contents of a list does not trigger a change script. Quest will consider it to be the same list. Say we have an attribute called "listofstuff". 

    // This will not trigger a change script
    list add (player.listofstuff, "item")
    // This will
    player.listofstuff = NewStringList()
    player.listofstuff = Split("first item,item", ",")


Order
-----

The change script will fire when the attribute changes, so be careful where you make the change in your code. In the hit points example, this is wrong:

    player.hitpoints = player.hitpoints - 20
    msg("You drink the liquid... and realised it was poison!")

If it kills the player, she will see this:

*You have died!!!*
*You drink the liquid... and realised it was poison!*

You need to adjust the hit points after the message.


Change Inside Change
--------------------

Be careful changing an attribute inside its own change script, you can easily end up in an infinite loop!


The "parent" Attribute
----------------------

An attribute you may well want to react to if it changes is the "parent" attribute, as this determines where an object is - what room it is currently in. You will find, however, that it already exists. You will need to click on "Make Editable Copy" to be able to do anything with it.

If the object in question is not the "player" object and will never be the player, you can just delete the existing code, and put n your own.

If this is the "player" object or can be the player, you will need to add your code to the end of the existing code. That said, if you go to the Scripts tab of the game object, there is a script there that will run every time the player enters a room, and you probably better using this.


The "oldvalue" variable
---------------------

There is a special variable that holds the previous value of the attribute your change script is following, and this is called "oldvalue". A good example of that in use is the change script on the "parent" attribute that was just mentioned:

if (game.pov = this) {
  if (IsDefined("oldvalue")) {
    OnEnterRoom (oldvalue)
  }
  else {
    OnEnterRoom (null)
  }
  if (game.gridmap) {
    MergePOVCoordinates
  }
}

The first line means that this code only applies if this object is the current player point-of-view (usually that is the "player" object). If this is the player, then the player has moved. It checks to see if *oldvalue* exists (which it should do, but is good to check). If it exists, it is passed to OnEnterRoom, which can then run the leaving script for the old room if necessary.


Implementing A BACK Command
---------------------------

So here is a real life use that brings some of those points together; a BACK command the player can type to go back to the previous room. We will assume the player's point of view does not change; the player is only ever the "player" object.

Go to the attributes tab of the player. In the lower box, look for the attribute called "changedparent". As mentioned before, it already exists, so will be in grey; click on "Name" to arrange them alphabetically to find it.

Click on it, so the script appears below, and then click on "Make Editable Copy", and then click on the Code view icon, to the right of that. You should see the script above.

Change it to this (fourth line has been inserted):

    if (game.pov = this) {
      if (IsDefined("oldvalue")) {
        OnEnterRoom (oldvalue)
        player.previousroom = oldvalue
      }
      else {
        OnEnterRoom (null)
      }
      if (game.gridmap) {
        MergePOVCoordinates
      }
    }

Then you need to create a new command. Give it "back" as a pattern. Paste in this code:

    if (player.previousroom = null) {
      msg ("You have not been anywhere yet, so how can you go back?")
    }
    else {
      msg ("You retrace your steps...")
      player.parent = player.previousroom
    }
