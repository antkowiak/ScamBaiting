# ScamBaiting
Tools for baiting phone-tech-support-scammers

Lately many folks are receiving unsolicited calls from scammers, or have seen a popup
in their web browser, prompting them to call an 800 phone number in order to
remove viruses, fix their computer, etc. These people are scammers.

The scammers operate by remotely logging into the victim's computer with some
remote access software (logmein, helpme.net, etc) and pretend to find viruses
or problems.

This repository will contain tools I create that will replace some of the executables
that the scammers use, with non-functional versions of the program, which may or may not
be funny to watch.

One typical scammer approach is to open up Notepad and have the user type their credit
card and billing information into the application.

Notepad - A "fake" version of notepad that only displays the text in an unreadable (Wingdings) font.

Notepad Random Typos - Another "fake" version of notepad, with a normal font... However, this version
introduces random changes to the text while typing stuff into Notepad.

Tree - A "fake" replacement for c:\windows\system32\tree.com. Scammers often run "tree" from a
command line, pretending that it is a virus scan. This replacement plays along with that,
and prints an ascii art tree, and then says that there are no viruses.
