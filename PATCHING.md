# How to make modifications to the game

This document describes how the patching functionality can be used to inject your own code into
the game and make it behave differently. If you haven't already, please read README.md first,
especially the "How it works" section.

Note that the patching functionality is extended on an as-needed basis. The things that aren't
possible right now are likely to be easily achievable, we just need a good reason to implement
them. Please contact Csaboka from the dev team if you need to do something not described here.

## About obfuscation

The SpaceChem executable is protected by obfuscation technology. This basically means that
the names of all of its types, methods and fields have been replaced with long strings of
random characters. This is typical for commercial .NET apps, as it prevents people from
casually understanding the mechanics using decompiler tools. The names are also generated
in such a way that they aren't valid C# identifiers, so you can't just recompile the code
that comes out of a decompiler. Before you can touch anything in the game code, you need
to figure out where the functionality lives, and learn the obfuscated names of all types,
methods and fields involved.

This document won't explain how to figure out obfuscated names. We don't want to publish
all the tools we use to do that since they could put Zachtronics intellectual property
at risk. The goal isn't to make a knock-off or clone of the game, but only to improve
the original. Please contact the dev team if you need help with finding obfuscated names.

## Creating decoys

Before you can inject your own code, you need to learn about decoys. Decoys are dummy counterparts
of actual game types, methods and fields. When you compile SpacechemPatch, the actual game code
isn't available, but you can instead reference the corresponding decoys. When the patches are
installed, references to the decoys are automatically replaced with references to the actual
counterparts. This lets you access game functionality without having to copy it into the
SpacechemPatch source code.

To create a decoy, you first create the thing (type/method/field) you want to access in the
SpacechemPatch source code. (Please use the Patches folder, so we have a nice separation between
infrastructure code and actual code replacements.) For everything except top-level types,
you also need to create a decoy for the containing type if there isn't one already. Then,
you annotate your decoy(s) with the `Decoy` attribute. `Decoy` has one mandatory positional argument,
which specifies the obfuscated name of the thing you want the decoy to refer to. Optionally,
you can also specify the namespace of the target when you create a type decoy, but the vast
majority of the types live in the default namespace, so this is rarely needed. It doesn't matter
what you call your decoy; by the time the patching is done, all references to it are replaced
by references to the originals anyway.

You should take care with methods that use special names at the IL level: constructors, class
constructors, property accessors and overloaded operators. The obfuscator doesn't change
the names of these since they would stop working. The `Decoy` attribute still requires an
obfuscated name in this case, so you need to specify the IL-level method name: ".ctor" for
constructors, ".cctor" for class constructors, "op_Equality" for operator== and so on.

Decoys only need the minimum content that makes them compile. In case of void methods and
constructors, an empty body is sufficient. For non-void methods, just have a dummy return
statement that returns whatever's convenient. (The body will be thrown away for decoys anyway.)

I'll give you an example of decoys in the next section.

## Replacing methods and constructors

Now that you understand obfuscation and decoys, you're ready for your first code replacement.
Replaced methods work almost like decoy methods, except that the method body *isn't* thrown
away, but overwrites the method body of the target method. To do this, use the `Replaced`
attribute in place of `Decoy`. Constructors work the same way as methods as far as replacement
is concerned, so I'll just refer to both as "methods" in this section.

`Replaced` also takes an obfuscated name as a positional argument. It can also take a list
of patches as a named argument. If you specify this, replacement is only executed if *any*
of the specified patches is enabled. If no patches are specified, replacement is unconditional.
Note that a replaced method also works as a decoy, i.e. you can call it from other code
and the call will be replaced with a call to the target method. This works *even if the corresponding
patch is disabled*, so you can always safely call replaced methods from other replaced methods,
but they might execute with their regular bodies instead of the replacement body.

To demonstrate, here is a simple example that uses a decoy type and a replacement method to make
the game consider all elements noble gases:

```csharp
[Decoy("#=qK2RFoTjRNITZZ33QNcQlMroK$uMcRhqsqBCdwyn2K2I=")]
internal static class ElementUtil
{
  [Replaced("#=q1HwnI$j1OJrBFSWZrDDtGLhHVhrvntzjkQ8$YqHNXOk=")]
  public static int GetMaxBonds(this Element element)
  {
    return 0;
  }
}
```

(Element is an enum that already has its decoy defined in SpacechemPatch.)

You can have multiple replacements to the same underlying target element, but if two or more of
them are active at the same time, only one will win, and you can't easily control which one it
will be. You should be careful with this functionality, and make sure to declare patch conflicts
properly. (See PatchInfo.cs for the details.)

## Injecting methods and fields

Method replacement is good enough for minor changes, but it won't let you store any new information
on the affected types. It also doesn't allow you to structure your code the way you want, but
forces you to do everything in one method. To fix this, injection of new methods and fields is also
supported.

To inject your method or field, declare them normally in a decoy type, then add the `Injected`
attribute to them. `Injected` doesn't take a parameter: it takes the injection target from the
parent type (which must be a decoy) and it injects the field or method with the same name it was
declared with. Technically you could collide with a field or method that's already on the class,
but most of those names are obfuscated and won't collide with your valid identifiers. The only
execption is special names, but if the target type has something that would collide, you're better
off using replacement anyway.

Injected methods and fields are discovered during method replacement, when a replaced (or injected)
method makes a reference to them. This means that they only get injected if they are actually used
by active patches, so they don't need to be annotated with a list of flags.

Note that *you can't initialize an injected field to a non-default value*! When you do that in
normal code, the compiler just silently copies the initialization to the top of all constructors,
or in the case of static fields, to the top of the class constructor. The patcher will only
consider the field, and will ignore the constructor body written by the compiler. If you can't have
your new field initialized to its default, you need to replace the constructor of the type and add
your field initialization there.

## Replacing a method and keeping the original

If you want to change a method just a little bit, it is probably overkill to replicate the whole
method body, not to mention you need to declare decoys for all the references it makes to make it
compile. To help with this use case, you can keep the original method around and call it from
your replacement.

To do this, first make a regular replacement method, then add the `KeepOriginal` named argument
to the `Replaced` attribute with the value `true`. Now you need to declare a method that you can
call to execute the original functionality. You have two options here:
* Keep the signature of the method and change its name. You'll need to specify the new name
  you have chosen in the `NewNameForOriginal` named argument. If you're replacing a class
  constructor, you can call the original as a static void method. You should prefer this
  option because it gives you more readable code. It won't work for constructors, though,
  because they must have a fixed name (`.ctor`) to work properly.
* Keep the name of the method and change its signature. _Do not_ specify the
  `NewNameForOriginal` argument. To make a new valid overload, you need to append a new
  dummy parameter with the type `SpacechemPatch.Original` to the parameter list. The value
  of this parameter is ignored, it's only used to allow selecting this new overload.
  If you're replacing a constructor, you can use the constructor delegation syntax to have
  the original called before the body of your replacement.

To build on the previous example, this is how you would turn noble gases into not-so-noble gases,
without changing the max. bond count of anything else:

Using the "new name" option:

```csharp
[Decoy("#=qK2RFoTjRNITZZ33QNcQlMroK$uMcRhqsqBCdwyn2K2I=")]
internal static class ElementUtil
{
  [Replaced("#=q1HwnI$j1OJrBFSWZrDDtGLhHVhrvntzjkQ8$YqHNXOk="), KeepOriginal = true, NewNameForOriginal = "OriginalGetMaxBonds"]
  public static int GetMaxBonds(this Element element)
  {
    int realBondCount = element.OriginalGetMaxBonds();
    return realBondCount == 0 ? 7 : realBondCount;
  }
  
  public static int OriginalGetMaxBonds(this Element element)
  {
    // This body doesn't matter, it won't be ever executed. Just do the minimum to keep the compiler happy.
    return 0;
  }
}
```

Using the "new signature" option:

```csharp
[Decoy("#=qK2RFoTjRNITZZ33QNcQlMroK$uMcRhqsqBCdwyn2K2I=")]
internal static class ElementUtil
{
  [Replaced("#=q1HwnI$j1OJrBFSWZrDDtGLhHVhrvntzjkQ8$YqHNXOk="), KeepOriginal = true]
  public static int GetMaxBonds(this Element element)
  {
    int realBondCount = element.GetMaxBonds(Original.INSTANCE);
    return realBondCount == 0 ? 7 : realBondCount;
  }
  
  public static int GetMaxBonds(this Element element, Original dummy)
  {
    // This body doesn't matter, it won't be ever executed. Just do the minimum to keep the compiler happy.
    return 0;
  }
}
```

The `INSTANCE` field of `Original` is just a convenience to get an Original reference. You can also
write `(Original) null` and it will have the same effect. The passed value is ignored anyway.

## GOG version support

The patcher was originally written to only handle the Steam executable of the game, then support
for the GOG version was added later. We didn't want to update all existing patches to add GOG
obfuscated names, so an alternative approach was chosen. The mapping between a Steam obfuscated
symbol and a GOG obfuscated symbol is defined in the Equivalences class, then the patcher uses
this mapping to translate between the two names if it needs to patch a GOG executable. The
mapping is built automatically, but the mapper tool has some limitations that sometimes
necessitate manual editing. See the README.md file of the ElementMatcher project for more details.

What this means to you is that you should either update the mapping file (if you have a GOG
executable and you're willing to match things up manually), or notify another developer
who has access to a GOG executable in the following cases:

* You add a new decoy or replacement for a nested type, or for any member of a nested type.
* You add a new decoy for an enum type.
* You add a new decoy or replacement for something else, and the obfuscated Steam name
  doesn't show up in the uncommented part of Equivalences.

Don't worry too much about double-checking GOG support, though. Before each release,
we'll test the code against a GOG executable, and any missing mappings will trigger
obvious crashes. By debugging those crashes, we can figure out what's missing from
the mapping and add it manually.

## Limitations

The following things don't work at the moment. If you need them, we can implement them for you.

* Injecting new types isn't implemented at all. The Original type used for replacement is injected
  using custom code that can't reproduce arbitrary types in the target.
* Lambdas won't work in replacement methods. When you write a lambda, the compiler turns it into a
  new hidden method and also adds a hidden field to cache the resulting delegate instance. The
  patcher won't inject these, so the lambda breaks.
* For similar reasons, `yield return` won't work. When you use this construct, the compiler writes
  a whole new IEnumerable implementation class for you and returns an instance of it. Type
  injection isn't implemented at the moment, so this won't work.
* There is no way to look at the list of active patches at runtime and make a dynamic decision
  based on them.
