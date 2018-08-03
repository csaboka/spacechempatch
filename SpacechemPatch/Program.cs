using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Mono.Cecil;
using Mono.Cecil.Cil;

namespace SpacechemPatch
{
    class Program
    {
        private static IEnumerable<KeyValuePair<T, CustomAttribute>> FindAnnotated<T>(IEnumerable<T> source, params string[] attributeNames) where T : ICustomAttributeProvider
        {
            return from elem in source
                   from attribute in elem.CustomAttributes
                   where attributeNames.Contains(attribute.AttributeType.Name)
                   select new KeyValuePair<T, CustomAttribute>(elem, attribute);
        }

        private delegate TypeDefinition TypeFinder(string @namespace, string typeName);

        private static void CollectReplacementsForTypes(IEnumerable<TypeDefinition> typeDefinitions, TypeFinder typeFinder, Dictionary<string, TypeReference> typeReplacements, Dictionary<string, MethodReference> methodReplacements, Dictionary<string, FieldReference> fieldReplacements)
        {
            foreach (KeyValuePair<TypeDefinition, CustomAttribute> typePair in FindAnnotated(typeDefinitions, "DecoyAttribute"))
            {
                TypeDefinition type = typePair.Key;
                CustomAttribute decoyAttribute = typePair.Value;
                string @namespace = "";
                if (decoyAttribute.Fields.Count != 0)
                {
                    @namespace = (string)decoyAttribute.Fields.First(field => field.Name == "namespace").Argument.Value;
                }
                string scrambledName = (string)decoyAttribute.ConstructorArguments[0].Value;
                TypeDefinition targetType = typeFinder(@namespace, scrambledName);
                typeReplacements.Add(type.FullName, targetType);
                foreach (KeyValuePair<MethodDefinition, CustomAttribute> methodPair in FindAnnotated(type.Methods, "ReplacedAttribute", "DecoyAttribute"))
                {
                    MethodDefinition decoyMethod = methodPair.Key;
                    CustomAttribute decoyMethodAttribute = methodPair.Value;
                    string targetMethodName = (string)decoyMethodAttribute.ConstructorArguments[0].Value;
                    MethodDefinition targetMethod = targetType.Methods.First(method => method.Name == targetMethodName);
                    methodReplacements.Add(decoyMethod.FullName, targetMethod);
                }
                foreach (KeyValuePair<FieldDefinition, CustomAttribute> fieldPair in FindAnnotated(type.Fields, "DecoyAttribute"))
                {
                    FieldDefinition decoyField = fieldPair.Key;
                    CustomAttribute decoyFieldAttribute = fieldPair.Value;
                    string scrambledFieldName = (string)decoyFieldAttribute.ConstructorArguments[0].Value;
                    FieldDefinition targetField = targetType.Fields.First(field => field.Name == scrambledFieldName);
                    fieldReplacements.Add(decoyField.FullName, targetField);
                }
                // Recurse for nested types.
                CollectReplacementsForTypes(type.NestedTypes, (dummy, typeName) => targetType.NestedTypes.First(t => t.Name == typeName), typeReplacements, methodReplacements, fieldReplacements);
            }
        }

        private static void CollectReplacements(ModuleDefinition spacechemAssembly, ModuleDefinition ownAssembly, out Dictionary<string, TypeReference> typeReplacements, out Dictionary<string, MethodReference> methodReplacements, out Dictionary<string, FieldReference> fieldReplacements)
        {
            typeReplacements = new Dictionary<string, TypeReference>();
            methodReplacements = new Dictionary<string, MethodReference>();
            fieldReplacements = new Dictionary<string, FieldReference>();
            CollectReplacementsForTypes(ownAssembly.Types, spacechemAssembly.GetType, typeReplacements, methodReplacements, fieldReplacements);
        }

        static void Main(string[] args)
        {
            string gameFolder = "";
            if (args.Length >= 1)
            {
                gameFolder = args[0];
            }
            string originalExecutablePath = Path.Combine(gameFolder, "SpaceChem.exe");
            string backupPath = Path.Combine(gameFolder, "SpaceChem.exe.original");
            string patchedPath = Path.Combine(gameFolder, "SpaceChem.exe.patched");
            if (!File.Exists(originalExecutablePath))
            {
                Console.WriteLine("Can't find game executable " + originalExecutablePath + " ! " +
                    "Please execute this program from the SpaceChem game folder, or give the path of the game folder as a command line argument. Exiting...");
                return;
            }
            Console.WriteLine("This program is experimental and was only tested with the Steam version of the game. There is NO WARRANTY on it. Please remember that you can always restore the original game files by verifying game integrity in Steam.");
            Console.WriteLine("Do you want to continue? [y/N]");
            if (Console.ReadKey().Key != ConsoleKey.Y) return;
            Console.WriteLine();
            if (!File.Exists(backupPath))
            {
                Console.WriteLine("Making backup of SpaceChem.exe");
                File.Copy(originalExecutablePath, backupPath);
            }
            // TODO: Add a way to specify this by the end user.
            Patch[] enabledPatches = (Patch[])Enum.GetValues(typeof(Patch));
            Console.WriteLine("Patching...");
            System.Reflection.Module currentModule = typeof(Program).Module;
            using (ModuleDefinition spacechemAssembly = ModuleDefinition.ReadModule(originalExecutablePath))
            using (ModuleDefinition ownAssembly = ModuleDefinition.ReadModule(System.Reflection.Assembly.GetExecutingAssembly().Location))
            {
                Dictionary<string, TypeReference> typeReplacements;
                Dictionary<string, MethodReference> methodReplacements;
                Dictionary<string, FieldReference> fieldReplacements;
                CollectReplacements(spacechemAssembly, ownAssembly, out typeReplacements, out methodReplacements, out fieldReplacements);
                Patcher patcher = new Patcher(typeReplacements, methodReplacements, fieldReplacements);
                foreach (KeyValuePair<TypeDefinition, CustomAttribute> decoyPair in FindAnnotated(ownAssembly.Types, "DecoyAttribute"))
                {
                    TypeDefinition cecilDecoyType = decoyPair.Key;
                    CustomAttribute cecilDecoyAttribute = decoyPair.Value;
                    string @namespace = "";
                    if (cecilDecoyAttribute.Fields.Count != 0)
                    {
                        @namespace = (string)cecilDecoyAttribute.Fields.First(field => field.Name == "namespace").Argument.Value;
                    }
                    string scrambledName = (string) cecilDecoyAttribute.ConstructorArguments[0].Value;
                    TypeDefinition targetType = spacechemAssembly.GetType(@namespace, scrambledName);

                    foreach (KeyValuePair<MethodDefinition, CustomAttribute> methodPair in FindAnnotated(cecilDecoyType.Methods, "ReplacedAttribute"))
                    {
                        MethodDefinition cecilReplacementMethod = methodPair.Key;
                        System.Reflection.MethodBase replacementMethod = currentModule.ResolveMethod(cecilReplacementMethod.MetadataToken.ToInt32());
                        ReplacedAttribute replacedAttribute = (ReplacedAttribute)Attribute.GetCustomAttribute(replacementMethod, typeof(ReplacedAttribute));
                        Patch[] patchesToEnableFor = replacedAttribute.Patches;
                        if (patchesToEnableFor.Length == 0 || patchesToEnableFor.Any(patch => enabledPatches.Contains(patch)))
                        {
                            MethodDefinition targetMethod = targetType.Methods.First(method => method.Name == replacedAttribute.ScrambledName && method.Parameters.Count == cecilReplacementMethod.Parameters.Count);
                            patcher.ReplaceMethod(cecilReplacementMethod, targetMethod);
                        }
                    }
                }
                spacechemAssembly.Write(patchedPath);
            }
            File.Delete(originalExecutablePath);
            File.Move(patchedPath, originalExecutablePath);
            Console.WriteLine("All OK");
        }
    }
}
