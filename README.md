# SpaceChemPatch

This program will modify your [SpaceChem](http://www.zachtronics.com/spacechem/) game executable to add new features to the game.

## Supported game versions

Development is done against the Steam version of the game that includes the 63 Corvi DLC, so this is the officially supported
version. The GOG version of the game is also supported in an experimental basis. We would like to get feedback from players
who have the GOG version before considering the support mature. If you have the GOG version, please try the patcher and
send your feedback to the development team; both positive and negative feedback is valuable at this point.

## Running it

There is a simple GUI. The program tries to automatically detect the steam installation folder, if it can't it must be selected manually.
Remember that the executable must be in the original SpaceChem folder:
if Steam detects that you've launched the game from the "wrong" folder, it will simply re-launch it from its expected location.
It'll then be possible to choose the patches to apply, from the list below

## Available patches

* `AllowGreekInResNet` & `AllowGreekInResNetProdAndSandbox`: Gives complete support for Greek annotations/sensors in ResearchNet levels.
  In the vanilla game it's possible to get Greek annotations/sensors in ResNet productions/sandbox, by copying a reactor from EotL, so the latter
  patch is merely a QoL one. It's not possible to have Greek sensors in ResNet research assignment, though, so the former patch makes the game
  easier and it's labeled as "Cheat".
* `DefaultDebondInDisassemblyReactors`: In disassembly reactors, the Bond+ instruction is always ignored because the bonders
  can only remove bonds in them. This patch replaces Bond+ with Bond- in the instruction toolbar for these reactors, so
  you don't need to manually switch them to the Bond- state.
* `FixWrongOutput`: The "wrong output" bug is fixed. The game is known to sometimes accept a molecule for output even when it doesn't
  completely match the expected molecule. The easiest way to reproduce this is to open the "Swapite" puzzle in ResearchNet 2-11-1:
  the game will accept the input molecule without any changes. This change will apply a different molecule matching algorithm that
  hopefully fixes these issues without introducing new ones. Please report any performance issues or unexpected results you encounter.
* `MoreFeaturesInResNetResearch`: Increase the upper limit of allowed reactor features in custom ResearchNet research puzzles.
  You can have up to 4 sensors, fusion lasers, fission lasers and quantum tunnels in a puzzle now. A Split instruction triggers all
  fission lasers in a reactor and a Fuse instruction triggers all fusion lasers. Sensing instructions will activate if any of
  the sensors detects the specified element. Quantum tunnels work in a "round-robin" fashion: tunnel #1 will teleport atoms to
  tunnel #2, tunnel #2 will teleport to tunnel #3 and so on, except for the highest-numbered tunnel, which will teleport to tunnel #1.
  Please read the "Compatibility Notes" section below if you also want to run the original game alongside the modified version.
* `ResNetProdCustomAmount`: Allows changing the amount of outputs needed for ResNet production puzzles. The amount can be specified in
  the JSON, like for researchs. The output count used by the game is 4x the amount in the file, to keep the 10 -> 40 behaviour of the vanilla game.
* `ReverseOrderCustomResNetAssignments`: The ResearchNet custom assignments are normally sorted by ascending creation date, meaning
  that you need to scroll the most to get to the latest puzzles. By enabling this patch, the order is reversed, so you can quickly open
  your most recent assignments and only need to scroll for the older ones.
* `ShowBonderPriority`: The priority of a bonder is shown in the top right corner of the cell.
  Bonder priority is something used by experienced players to predict which bonds will form when not all of the possible bonds can be formed
  during a Bond+ instruction (usually because of the maximum bonds limit of one of the atoms involved).
* `ShowOver100kCycles`: The cycles counter in the game switches to `+INF` after 100k cycles. This patch makes it continue with `100K`,
  up until `9999K`, then `10M`. The value displayed updates at the start of the new thousand (e.g. `100999` is shown as `100K`).
* `ShowReactorPriority`: The priority of reactors, tanks and printers is shown in production and defense puzzles.
  Priority is useful for cycles optimization: in some cases, you can save one cycle by making sure that the reactor that's outputting
  a molecule has lower priority than the reactor accepting it, allowing the molecule to be accepted in the same cycle.
  Inputs' and outputs' priority isn't shown, as they both trigger before anything else.
* `SuperFastForward`: Allows you to run the simulation at maximum speed (i.e. whatever your computer can handle) by holding down Ctrl
  and clicking on the fastest speed button in the bottom left corner. (Technically, the simulation is set up to run at 10,000 cycles
  per second, but even today's computers won't be able to run the simulation that quickly.) Expect heavy lagging when triggering this
  speed.

## Compatibility Notes

There is currently one patch that may cause compatibility issues with the vanilla game:

* When `MoreFeaturesInResNetResearch` is active, the puzzle descriptions used by the game are extended with new fields to store the
  selected feature counts. When the vanilla game loads these descriptions, it will ignore the new fields and enforce the old limits.
  When it's loading a puzzle solution, it will also remove the "extra" features it finds that are above the expected limits. The result is,
  whenever you open the Custom Assignments screen in ResearchNet with the vanilla game, you will lose features in your existing solutions,
  and restoring those features is tricky at the moment. If you wish to switch between the vanilla and patched versions of the game,
  it's better to avoid opening this screen, or even to use different game profiles for the two versions.  
  Exporting puzzles should work normally, but if you publish your puzzle somewhere, please let the players know that they will need to
  patch their game to be able to play the puzzle properly. The `MoreFeaturesInResNetResearch` is the only patch necessary, all others
  can stay disabled if the player prefers the original game behavior.

## Getting Started With Development

The project consists of a Visual Studio 2015 solution file. You should be able to build it with either Visual Studio, or the Mono development tools on Linux.

To add new patches, please read the "How it works" section below, then refer to PATCHING.md for the low-level details.

### Prerequisites

You will need to get the `Mono.Cecil` library from NuGet. This library does the heavy lifting in assembly modification.

### How it works

The SpaceChem executable is obfuscated, and one part of the obfuscation is renaming identifiers. The new names are not legal symbols in C#,
so you can't just pull the binary as a dependency and access the types.
It's still possible to create IL code manually and overwrite the existing code with it, but doing that from a C# program is very cumbersome.

To work around this, the code contains "decoy" types, methods and fields.
These are readable counterparts of the obfuscated elements, which can be used normally from C# code.
When you need to change a method, you need to find all the obfuscated functionality your method is going to use,
create "decoy" counterparts of that functionality (just enough to make things compile, i.e. no need to copy method bodies),
then write the new method body. Annotate the new method with `[Replaced]`, then annotate everything else you've added with `[Decoy]`.
Both of these attributes will need the obfuscated name of the corresponding real element.
It is also possible to inject new fields into SpaceChem types by declaring your field on the decoy and annotating it with `[Injected]`.
Please note that field initializers won't work;
you'll need to replace the constructor if you can't work with the field being initialized to its default.

During patching, the assembly will load itself with Cecil, find all annotated elements,
then replace method bodies of the SpaceChem assembly where requested.
While replacing, it will inspect the code and replace any mentions of "decoy" elements with their real counterparts.
This way, you can let the C# compiler do the IL generation for you. Refer to the Patcher class for details.

## Acknowledgments

* Kudos to [gtw123](https://github.com/gtw123), whose [ShenzhenMod](https://github.com/gtw123/ShenzhenMod) project inspired me to give this a try.
  He pointed out the right tools to get this started.
* [darkid](https://github.com/jbzdarkid) and [12345ieee](https://github.com/12345ieee) for their immense help in understanding game internals.
* [12345ieee](https://github.com/12345ieee) again, for building the user interface of the tool
