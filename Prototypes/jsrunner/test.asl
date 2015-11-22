' Created with QDK 4.1.5

!include <stdverbs.lib>

define game <>
	asl-version <410>
	start <room>
	game info <Created with QDK 4.1.5>
	command <test> {
		msg <Enter some words...>
		enter <input>
		msg <You typed: #input#>
		msg <Type something else.>
		enter <input2>
		msg <First #input#, now #input2#.>
	}
	command <test2> {
		wait <Press a key please...>
		msg <Done!>
		wait <Now press a key again...>
		msg <Finished!>
	}
	verb <read> msg <You can't read that.>
end define

define options
	debug on
	panes on
	abbreviations on
end define

define room <room>
	east <kitchen>

	define object <thing>
		displaytype <Object>
		article <it>
		gender <it>
	end define

	define object <book>
		look <Just an ordinary book.>
		take
		displaytype <Object>
		article <it>
		gender <it>
		properties <read = A very interesting read.>
	end define

end define

define room <kitchen>
	west <room>
end define

