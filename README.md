# SpaceChemPatch

This program will modify your SpaceChem game executable to add new features to the game.

## Running it

This is a command-line tool. You can either copy it (and all the related files included in the release) into your SpaceChem folder and simply double-click on it,
or you can extract the release somewhere else, then specify the location of your SpaceChem folder as a command-line argument. In either case, only your original
SpaceChem folder will work -- if Steam detects that you've launched the game from the "wrong" folder, it will simply re-launch it from its expected location.

## What it changes

* The priority of a bonder is shown in parentheses when you hover over it while editing a reactor. Bonder priority is something used by experienced players
  to predict which bonds will form when not all of the possible bonds can be formed during a Bond+ instruction (usually because of the maximum bonds limit
  of one of the atoms involved). There is a known bug with this change: when you first open a puzzle you haven't worked on before, all bonders will show
  up with (max+1) priority. As a workaround, you should make some change to the reactor (even placing an arrow will work), then close and reopen it to
  make the right priorities show up.
* The "wrong input" bug is fixed. The game is known to sometimes accept a molecule for output even when it doesn't completely match the expected molecule.
  The easiest way to reproduce this is to open the "Swapite" puzzle in SpaceChem; the game will accept the input molecule without any changes. This change
  will apply a different molecule matching algorithm that hopefully fixes these issues without introducing new ones. Please report any performance issues
  or unexpected results you encounter.

## Getting Started With Development

The project consists of a Visual Studio 2015 solution file. You should be able to build it with either Visual Studio, or the Mono development tools on Linux.

### Prerequisites

You will need to get the Mono.Cecil library from NuGet. This library does the heavy lifting in assembly modification.

### How it works

The SpaceChem executable is obfuscated, and one part of the obfuscation is renaming identifiers. The new names are not legal symbols in C#, so you can't just pull the binary as a dependency and access the types. It's still possible to create IL code manually and overwrite the existing code with it, but doing that from a C# program is very cumbersome.

To work around this, the code contains "decoy" types, methods and fields. These are readable counterparts of the obfuscated elements, which can be used normally from C# code. When you need to change a method, you need to find all the obfuscated functionality your method is going to use, create "decoy" counterparts of that functionality (just enough to make things compile, i.e. no need to copy method bodies), then write the new method body. Annotate the new method with \[Replaced\], then annotate everything else you've added with \[Decoy\]. Both of these attributes will need the obfuscated name of the corresponding real element. It is also possible to inject new fields into SpaceChem types by declaring your field on the decoy and annotating it with \[Injected\]. Please note that field initializers won't work; you'll need to replace the constructor if you can't work with the field being initialized to its default.

During patching, the assembly will load itself with Cecil, find all annotated elements, then replace method bodies of the SpaceChem assembly where requested. While replacing, it will inspect the code and replace any mentions of "decoy" elements with their real counterparts. This way, you can let the C# compiler do the IL generation for you. Refer to the Patcher class for details.

## Acknowledgments

* Kudos to [gtw123](https://github.com/gtw123), whose [ShenzhenMod](https://github.com/gtw123/ShenzhenMod) project inspired me to give this a try. He pointed out the right tools to get this started.
