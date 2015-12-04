---
layout: index
title: The "parent" Attribute
---


One of the most important attributes in Quest is the "parent" attribute, but you can easily miss it even exists.

The "parent" attribute defines where an object is, both in the game and in the editor. If you create a room, and put an object in it, the object will appear under the room in the pane on the left. It does so because its "parent" attribute is set to the room.

If you are off-line, you can go to the attributes tab, find the "parent" attribute, and set it to another room, and suddenly the object will be under the new room in the left pane.

If you want an item to start the game in a container, move it to the container in the left pane, and if you check on the Attrributes tab, you will see the "parent" attribute is set to that container.


Using the Attribute
-------------------

In game, you can move items around just by setting their parent attribute.

    // Move the player to the throne room
    player.parent = throne_room

    // Put the crystal in the chest
    crystal.parent = chest

    // Give the sword to the player
    sword.parent = player

    // Move the orc to the same room as the player
    orc.parent = player.parent


Quest does have a MoveObject function and a MoveObjectHere function, but if you look at the code, they do no more and no less than change the parent attribute.


Checking where something is
---------------------------

Just as you can set the attrribute, you can test it too:

    // Is the player in the throne room?
    if (player.parent = throne_room) {
      ...

    // Is the crystal in the chest?
    if (crystal.parent = chest) {
      ...

    // Does the player have the sword?
    if (sword.parent = player) {
      ...

    // Are the orc and the player in the same room?
    if (orc.parent = player.parent) {
      ...
      

Reacting to something moving
----------------------------

Occasionally you want to know if an object has been moved or put in a certain place. A useful technique for that is a [change script](change_scripts.html) on the parent attribute.
