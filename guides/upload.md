---
layout: index
title: Uploading Your Game
---

If you are working on-line, this is not relevant to you.

If you are working off-line, you need to prepare your game to get it ready for upload to the Text Adventures web site. This is usually very easy. Let us suppose your game is called "My Great Game".

Go to the "Setup" tab of the game object, and check all the details are correct. This is information the web site will use to create an entry for your game, so check you have "Cover art" (this is the image people see when browsing the web site), select a category, an author; make sure you have a name and a description for your game.

Save your game.

Go to *Tool - Publish*. Quest will then produce a file called "My Great Game.quest", which you will find here:

    My Documents\Quest Games\My Great Game\output\My Great Game.quest

Go to the Quest website, sign in, click on "Create" at the top, then on "Upload Game". You can then read the rules for submission, and if you are happy to comply, click the "Browse..." towards the bottom, and find your .quest file on your computer. Then click "Upload".


What Files Get Included?
------------------------

The publish process does three things. First it creates one big file from your game and any library files you are using. By default you will have the core library and the English language; you might have any number of others.

Secondly it collects together all your other files. Quest does not know what files you are actually using, so it grabs all the files in the folder that have certain extensions (i.e., the file name ends with certain characters).

This is the folder it looks in:

    My Documents\Quest Games\My Great Game

These are the file extensions it looks for:

    *.jpg;*.jpeg;*.png;*.gif;*.js;*.wav;*.mp3;*.htm;*.html;*.svg

You can change the default files it looks for by changing this attribute:

    game.publishfileextensions

By the way, whenever you add a file to Quest via the GUI - whether that is an image, a sound file, a Javascript file or a library - if it is not already in your game folder, Quest will create a copy of it there, so you do not have to worry about collecting them all together.
    
Lastly, the single Quest file plus all your media files are compressed, to make a single package.


Testing
-------

It is good practice to publish your game as "Unlisted" until you are confident it is completed, however tempting it is to tell everyone about it as soon as possible.

Now it is uploaded, play it yourself for ten minutes, and check it looks the same (or near enough) as it did when you played it off-line. Save your place in the game, and then see what happens if you start again from a saved game.

Get some people to "beta test" your game. They *will* find problems.

Upload you game again, and the old version will get over-written (but the values on the Setup tab of game do not get updated; they can however be edited through the web site). Test again. Once the game is perfect, set the game visibility to "Public" on the web site via the "Edit this listing" button.

Now you can tell everyone about it!


My Game Is Too Big!
-------------------

The website seems to have a limit of 20 Mb for uploaded files, and if you have a lot of images and sounds, you might find you exceed that limit. What can you do?

If you have any files you are not using, move them to another folder, so Quest will not include them.

Try reducing the size of the media files, for example with Pixillion Image Converter and Switch Sound Converter. Be aware that this is likely to reduce their quality as well. Windows Explorer will tell you the size of the files in a folder if you right click in the right pane, and select *View - Details*. You can also order the files by size, which may be useful when trying to work out which files are the problem.

Note that the .quest file is already compressed.
