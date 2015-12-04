---
layout: index
title: Start Coding in Quest
---

Writing code is not trivial, and I cannot hope to make you an expert here. However, it is not as difficult as you might think, and hopefully this will get you started.

Quest uses three languages, including XML. If you click on *Tools - Code view* you will see the XML. Writing XML is a pain in the neck - let Quest do that for you. The only time I ever look at this code view is when I have spotted a typo when playing my game and want to quickly find it to correct it (do *[CTRL]-F* to search by the way).

Quest also uses Javascript, but unless you want to do fancy stuff with the interface, you can ignore that. This is not about JavaScript.

The important one is the one used in scripts, and that is unique to Quest. It is kind of similar to C++/Java and many of the built-in functions come from Visual BASIC.


A Note About Objects
--------------------

The word "object" has two distinct meanings in Quest. Firstly it can mean something that the player can interact with, perhaps pick up, examine, etc. However, in the programming world it means any data structure, and in that sense it includes rooms, exits, the game object and indeed everything in the game world. When I use the word "object", I mean it in this second sense. I will use the word "item" to indicate the first meaning (however, if I am quoting a label or dialogue box, "object" will probably mean item).


Code View - Scripts/Blocks
--------------------------

Scripts are found in several places in Quest. Functions and commands are little more than scripts, but you can also attach scripts to items, rooms and exits. Rooms can be set to run a script when the player enters or leaves. Verbs on objects are all scripts, exits can run a script when used, items can run a script when picked up or dropped.

To see code look for the script on an object, and click on the seventh icon ([i]View code[/i]).

![](code1.png "code1.png")

Here is an example from a built-in command, INVENTORY:

    list = FormatObjectList(Template("CarryingListHeader"), game.pov, Template("And"), ".")
    if (list = "") {
      msg (Template("NotCarryingAnything"))
    }
    else {
      msg (list)
    }

At its simplest, code is a list of instructions. When the script starts (the player enters the room, drops the item, or whatever), Quest starts at the top and does each line in turn - just like following a recipe when baking a cake.

Here is a simple example that might be set on an exit:

    msg("You crawl for some time through the dark tunnel, before arriving at...")
    player.parent = this.to

Quest does the first line, which prints out the message, then the second line, which moves the player.


Attributes
----------

Objects have attributes, which are values with names. You can set these up on the Attributes tab for any object, but everything you set on the other tabs is an attribute too, with a pre-defined name. An attribute can be a string, an integer, another object or a script and more besides.

In code, you can access an attribute using the dot operator. The above example accesses the "parent" attribute of the player object and the "to" attribute of "this".


What is "this"?
---------------

"this" has a special meaning, it refers to the object that this script belongs to. In the example, then, "this" refers to the exit itself. I could have used the name of the exit instead, but generally it is better to use "this", as it allows your code to be reused more easily.

All exits have a "to" attribute which is an object (or technically a pointer to an object); the destination of the exit, so "this.to" is the destination of the exit that the script belongs to.


What is "parent"?
-----------------

All items and exits have a "parent" attribute (rooms can too). It indicates the object's position in the hierarchy in the left pane, or who the object belongs to. Any item that belongs to the player is in the player's inventory; it has the player as its parent. Any item or exit in a room has that room as the parent, and similarly if the player has a room as its parent, then the player is in that room. Any item that has another item as its parent is inside that object (though you need to set up the latter as a container for that to work properly).

To move the player to a new room, all you have to do is set the player's parent to the new room. This is what the script above does. It sets the player's parent to be whatever room is indicated by the "to" attribute of this exit.

To move an item to the player, set the item's parent to the player.

    my_item.parent = player

To move an item to the current room, set its parent to the player's parent

    my_item.parent = player.parent


Aside: About "player"
---------------------

Just be aware that Quest has the capability for changing the point of view (i.e. swapping from one player character to another) built-in. To handle that, Quest has an attribute of the game object called "pov", and that refers to the current player. To be able to change the player's point of view, we should use "game.pov" rather than "player". I mention this for completeness; I am going to continue to use "player" to keep things simple, but if you look at code in a library it will probably use "game.pov".


Computers are fussy
-------------------

You have to be precise when writing code. Computers will not cope if you miss a quote or a bracket. To check you have not missed something, always click on the *View code* icon and check there is no red writing. Scroll down to check. The example below shows an error some way down the page, in this case a missing bracket.

![](code2.png "code2.png")

Working out what is missing can be tricky! However, if you do not check at this stage, Quest will sometimes try to correct the problem itself, which sometimes means deleting big chunks of code, leaving it in rather more of a mess.


Quotes in strings
-----------------

Given a double quote terminates a string, how do you handle doubles quotes? This is going to fail:

    msg ("The scarecrow looks at you. "Howdy!" he says.")

Quest will consider "The scarecrow looks at you. " to be a string, and " he says." to be another, and will try to work out what Howdy! is supposed to mean! The trick is to use an escape code; put a backslash before the double quotes within the string. This will work fine.

    msg ("The scarecrow looks at you. \"Howdy!\" he says.")

If you want to put a backslash into a string, you need to escape that two, so use \\.


Functions
---------

Quest has a large number of script commands and functions, listed on these helpful pages:
[Script commands](../scripts/)
[Functions](../functions/)

See here for how to write your own:
[Using and Coding Functions](using_functions)


Lists
-----

Lists are very useful, but are explained elsewhere, so just go there:
[Lists](using_lists.html)


Control Structures
------------------

A control structure allows code to break out of the simple recipe. Instead of just doing each line in turn, we can get Quest to perform some lines repeatedly or to only do certain lines if specific conditions are met.

Control structures have the same general format. First there is the script command, then the values, then the instructions. The values all go inside a set of brackets, and separated by commas. The instructions all go on separate lines (just like normal code), and inside a set of curly braces. To help make it easier to read, the instructions are indented. Quest will do this for you, but I recommend getting in the habit of doing it yourself anyway.

Let us have a look at a couple:


The "foreach" Loop
------------------

This is how to go through each entry in a list. Quest has a number of *Scope* functions that will grab all the appropriate items. For example, *ScopeInventory* gives us a list of items in the player's inventory. We can use that with "foreach".

    foreach (item, ScopeInventory()) {
      msg("You dry out " + GetDisplayAlias(item))
      item.wet = false
    }

The first thing is the script command, "foreach". Next we have the values, and these are inside brackets, separated by commas. In this case, the first is a variable that we can use in the code section. The second is the list, which we are getting from *ScopeInventory*.

Then there are the instructions. In this case there are two, each on its own line, indented by two spaces. They are surrounded by curly braces.

Quest will go though the objects returned by *ScopeInventory*. For each one in turn, it will put the value in "item" and then run the code.


The "if" Structure
------------------

You use "if" to make the script sometimes do one thing and sometimes another. In this simple example, the message is only seen if the hat item is in this room.

if (hat.parent = this) {
  msg("There is a bowler hat on the hatstand.")
}

You can add an "else" if you want; this will get done if the condition *fails*:

if (hat.parent = this) {
  msg("There is a bowler hat on the hatstand.")
}
else {
  msg("The hatstand is devoid of hats.")
}


Complex Testing
---------------

You can append an "if" to an "else", to make complex structures. In an adventure game, a common use is to check all the conditions have been met before something happens. This example might be the script for a SIT command.

if (not this.has_chair) {
  msg("There's nowhere to sit here!")
}
else if (not player.parent.name = clown_room) {
  msg("Okay, you sit down. Now what?")
}
else if (not hat.worn) {
  msg ("You sit on the orange chair. A clown suddenly appears in the room, looks at your head in confusion, then disappears as quickly.")
}
else if (clown.parent = clown_room) {
  msg("You are already sat down.")
}
else {
  msg ("You sit on the orange chair. A clown suddenly appears in the room, and knocks the hat off your head.")
  hat.worn = false
  hat.parent = clown_room
  clown.parent = clown_room
}

The strategy here is to test each condition has [i]not [/i]been met in turn, and give a suitable response if it fails. Only if each condition passes do we reach the final "else", where the player has solved the puzzle and the game world gets updated.


Complex conditions
------------------

You can do some complicated condition testing in Quest. To test if conditions are all true, use the "and" operator, and to test if at least one is true, use "or". You can also test a condition is not true using "not". In this example all the above conditions are checked at once (the first implicitly).

if (player.parent.name = clown_room and hat.worn and not clown.parent = clown_room) {
  msg ("You sit on the orange chair. A clown suddenly appears in the room, and knocks the hat off your head.")
}
else {
  msg("Nothing happens.")
}

Having said that, the previous way is generally better, as it is clearer to you the coder what tyou are testing for and it is clearer to the player why nothing is happening.