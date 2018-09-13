# Element matcher tool

This is a rudimentary tool to help automate the addition of new game binaries to the patcher.
It takes two executables and tries to match up the top-level non-enum types based on some
features of the code that aren't affected by obfuscation:

* The relative order of fields and methods. (The obfuscator used by the game doesn't seem
  to alter the order in the vast majority of cases.)
* Type, field and method attributes.
* Number of fields and methods in a type.
* Field types and method signatures that use built-in .NET types

## How to use

The tool takes three command-line arguments: the paths of the source and target executables,
and the path of the file where a C# snippet will get written. Normally, you specify the
Steam version of SpaceChem.exe as the source executable (since that's the version whose
obfuscated names are used in the patch source), and an unknown SpaceChem.exe variant as the
target executable. The resulting snippet can be then added to the Equivalences class.

## Limitations

The tool can't match enums because almost all of them are gutted out by the obfuscator,
so there is nothing to match against. To match them up, you would need an alternative
approach, such as finding an enum mentioned in a method signature then finding the
same slot in the signature of the target method. It also doesn't try to match up
nested methods because it didn't feel like it was worth the effort. When a nested
type is needed by the patcher, matching it up by hand should be easy because you
only have a small number of candidates to try.

The matching doesn't always work for top-level non-enum types, either. Sometimes
there is no match. Most of these failed matches are triggered by Steam-specific
types that aren't present in non-Steam versions, and the tool tries to filter
those out. For the rest, the target type doesn't have the expected layout for
whatever reason, and you must do the matching by hand. It's also possible to
find more than one match, typically in small classes whose signatures end
up being the same. You have to do manual matching here as well, but at least
you have a short list of potential matches. Both kinds of failures (no match
and multiple matches) are emitted at the end of the C# snippet as comments,
to help with hand-editing the resulting file and adding whatever is still
needed for a successful patch.