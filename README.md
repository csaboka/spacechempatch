# SpaceChemPatch

This program will modify your SpaceChem game executable to add new features to the game. Currently the only feature is showing bonder priority in the bonder tooltip.

## Getting Started

The project is in its early stage, so all I have is a Visual Studio 2015 solution file. I only have Windows to test with, but feel free to send me instructions if you can get it to build and run on other OSes.

### Prerequisites

You will need to get the Mono.Cecil library from NuGet. This library does the heavy lifting in assembly modification.

### How it works

The SpaceChem executable is obfuscated, and one part of the obfuscation is renaming identifiers. The new names are not legal symbols in C#, so you can't just pull the binary as a dependency and access the types. It's still possible to create IL code manually and overwrite the existing code with it, but doing that from a C# program is very cumbersome.

To work around this, the code contains "decoy" types, methods and fields. These are readable counterparts of the obfuscated elements, which can be used normally from C# code. When you need to change a method, you need to find all the obfuscated functionality your method is going to use, create "decoy" counterparts of that functionality (just enough to make things compile, i.e. no need to copy method bodies), then write the new method body. Annotate the new method with \[Replaced\], then annotate everything else you've added with \[Decoy\]. Both of these attributes will need the obfuscated name of the corresponding real element.

During patching, the assembly will load itself with Cecil, find all annotated elements, then replace method bodies of the SpaceChem assembly where requested. While replacing, it will inspect the code and replace any mentions of "decoy" elements with their real counterparts. This way, you can let the C# compiler do the IL generation for you.

Not everything is supported yet. In particular, generic method calls won't work because the decoy types won't be replaced in the signature. Refer to the Patcher class for details.

## Acknowledgments

* Kudos to [gtw123](https://github.com/gtw123), whose [ShenzhenMod](https://github.com/gtw123/ShenzhenMod) project inspired me to give this a try. He pointed out the right tools to get this started.
