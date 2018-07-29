using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Cecil.Rocks;

namespace SpacechemPatch
{
    class Program
    {
        private static void CollectReplacements(ModuleDefinition spacechemAssembly, ModuleDefinition ownAssembly, out Dictionary<TypeReference, TypeReference> typeReplacements, out Dictionary<MethodReference, MethodReference> methodReplacements, out Dictionary<FieldReference, FieldReference> fieldReplacements)
        {
            typeReplacements = new Dictionary<TypeReference, TypeReference>();
            methodReplacements = new Dictionary<MethodReference, MethodReference>();
            fieldReplacements = new Dictionary<FieldReference, FieldReference>();
            var decoyTypes = from type in ownAssembly.Types
                             where type.HasCustomAttributes && type.CustomAttributes.Any(att => att.AttributeType.Name == "DecoyAttribute")
                             select type;
            foreach (TypeDefinition type in decoyTypes) {
                CustomAttribute decoyAttribute = type.CustomAttributes.First(att => att.AttributeType.Name == "DecoyAttribute");
                string @namespace = "";
                if (decoyAttribute.Fields.Count != 0)
                {
                    @namespace = (string)decoyAttribute.Fields.First(field => field.Name == "namespace").Argument.Value;
                }
                string scrambledName = (string)decoyAttribute.ConstructorArguments[0].Value;
                TypeDefinition targetClass = spacechemAssembly.GetType(@namespace, scrambledName);
                typeReplacements.Add(type, targetClass);
                var decoyMethods = from method in type.Methods
                                         where method.HasCustomAttributes && method.CustomAttributes.Any(att => att.AttributeType.Name == "ReplacedAttribute" || att.AttributeType.Name == "DecoyAttribute")
                                         select method;
                foreach (MethodDefinition decoyMethod in decoyMethods)
                {
                    CustomAttribute decoyMethodAttribute = decoyMethod.CustomAttributes.First(att => att.AttributeType.Name == "ReplacedAttribute" || att.AttributeType.Name == "DecoyAttribute");
                    string targetMethodName = (string)decoyMethodAttribute.ConstructorArguments[0].Value;
                    MethodDefinition targetMethod = targetClass.Methods.First(method => method.Name == targetMethodName);
                    methodReplacements.Add(decoyMethod, targetMethod);
                }
                var decoyFields = from field in type.Fields
                                  where field.HasCustomAttributes && field.CustomAttributes.Any(att => att.AttributeType.Name == "DecoyAttribute")
                                  select field;
                foreach (FieldDefinition decoyField in decoyFields)
                {
                    CustomAttribute decoyFieldAttribute = decoyField.CustomAttributes.First(att => att.AttributeType.Name == "DecoyAttribute");
                    string scrambledFieldName = (string)decoyFieldAttribute.ConstructorArguments[0].Value;
                    FieldDefinition targetField = targetClass.Fields.First(field => field.Name == scrambledFieldName);
                    fieldReplacements.Add(decoyField, targetField);
                }
            }
        }

        static void Main(string[] args)
        {
            if (!File.Exists("spacechem.exe"))
            {
                Console.WriteLine("This program needs to be placed next to Spacechem.exe to work! Exiting...");
                return;
            }
            Console.WriteLine("This program is experimental and was only tested with the Steam version of the game. There is NO WARRANTY on it. Please remember that you can always restore the original game files by verifying game integrity in Steam.");
            Console.WriteLine("Do you want to continue? [y/N]");
            if (Console.ReadKey().Key != ConsoleKey.Y) return;
            Console.WriteLine();
            if (!File.Exists("spacechem.exe.original"))
            {
                Console.WriteLine("Making backup of spacechem.exe");
                File.Copy("spacechem.exe", "spacechem.exe.original");
            }
            Console.WriteLine("Patching...");
            using (ModuleDefinition spacechemAssembly = ModuleDefinition.ReadModule("spacechem.exe"))
            using (ModuleDefinition ownAssembly = ModuleDefinition.ReadModule(System.Reflection.Assembly.GetExecutingAssembly().Location))
            {
                Dictionary<TypeReference, TypeReference> typeReplacements;
                Dictionary<MethodReference, MethodReference> methodReplacements;
                Dictionary<FieldReference, FieldReference> fieldReplacements;
                CollectReplacements(spacechemAssembly, ownAssembly, out typeReplacements, out methodReplacements, out fieldReplacements);
                Patcher patcher = new Patcher(typeReplacements, methodReplacements, fieldReplacements);
                List<TypeDefinition> decoyClasses = new List<TypeDefinition>(from type in ownAssembly.Types
                                   where type.HasCustomAttributes && type.CustomAttributes.Any(att => att.AttributeType.Name == "DecoyAttribute")
                                   select type);
                foreach (TypeDefinition decoyClass in decoyClasses)
                {
                    CustomAttribute decoyAttribute = decoyClass.CustomAttributes.First(att => att.AttributeType.Name == "DecoyAttribute");
                    string @namespace = "";
                    if (decoyAttribute.Fields.Count != 0)
                    {
                        @namespace = (string)decoyAttribute.Fields.First(field => field.Name == "namespace").Argument.Value;
                    }
                    string scrambledName = (string) decoyAttribute.ConstructorArguments[0].Value;
                    TypeDefinition targetClass = spacechemAssembly.GetType(@namespace, scrambledName);

                    var replacementMethods = from method in decoyClass.Methods
                                             where method.HasCustomAttributes && method.CustomAttributes.Any(att => att.AttributeType.Name == "ReplacedAttribute")
                                             select method;
                    foreach (MethodDefinition replacementMethod in replacementMethods)
                    {
                        CustomAttribute replacementAttribute = replacementMethod.CustomAttributes.First(att => att.AttributeType.Name == "ReplacedAttribute");
                        string targetMethodName = (string) replacementAttribute.ConstructorArguments[0].Value;
                        MethodDefinition targetMethod = targetClass.Methods.First(method => method.Name == targetMethodName && method.Parameters.Count == replacementMethod.Parameters.Count);
                        patcher.ReplaceMethod(replacementMethod, targetMethod);
                    }
                }
                spacechemAssembly.Write("spacechem.exe.patched");
            }
            File.Delete("spacechem.exe");
            File.Move("spacechem.exe.patched", "spacechem.exe");
            Console.WriteLine("All OK");
        }
    }
}
