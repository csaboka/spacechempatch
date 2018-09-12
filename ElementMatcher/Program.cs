using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mono.Cecil;

namespace ElementMatcher
{
    class Program
    {
        private static bool TypesAreEqual(TypeDefinition x, TypeDefinition y)
        {
            if (x.Attributes != y.Attributes)
            {
                return false;
            }
            if (x.Fields.Count != y.Fields.Count || x.Methods.Count != y.Methods.Count || x.CustomAttributes.Count != y.CustomAttributes.Count)
            {
                return false;
            }
            for (int i = 0; i < x.Fields.Count; i++)
            {
                if (x.Fields[i].Attributes != y.Fields[i].Attributes || !TypeMatches(x.Fields[i].FieldType, y.Fields[i].FieldType))
                {
                    return false;
                }
            }
            for (int i = 0; i < x.Methods.Count; i++)
            {
                if (x.Methods[i].Attributes != y.Methods[i].Attributes || x.Methods[i].Parameters.Count != y.Methods[i].Parameters.Count)
                {
                    return false;
                }
            }
            for (int i = 0; i < x.CustomAttributes.Count; i++)
            {
                bool hasMatch = false;
                for (int j = 0; j < y.CustomAttributes.Count; j++)
                {
                    if (CustomAttributeMatches(x.CustomAttributes[i], y.CustomAttributes[j]))
                    {
                        hasMatch = true;
                        break;
                    }
                }
                if (!hasMatch)
                {
                    return false;
                }
            }
            return true;
        }

        private static bool TypeMatches(TypeReference x, TypeReference y)
        {
            if (!(x is ArrayType) && !(x is GenericInstanceType) && (x.Namespace == "System"))
            {
                return x.FullName == y.FullName;
            }
            else
            {
                return true;
            }
        }

        private static bool CustomAttributeMatches(CustomAttribute x, CustomAttribute y)
        {
            if (x.ConstructorArguments.Count != y.ConstructorArguments.Count || x.Fields.Count != y.Fields.Count || x.Properties.Count != y.Properties.Count)
            {
                return false;
            }
            for (int i = 0; i < x.ConstructorArguments.Count; i++)
            {
                if (!Object.Equals(x.ConstructorArguments[i].Value, y.ConstructorArguments[i].Value))
                {
                    return false;
                }
            }
            // SC attributes only use constructor arguments
            return true;
        }

        static void Main(string[] args)
        {
            Dictionary<TypeDefinition, TypeDefinition> equivalences = new Dictionary<TypeDefinition, TypeDefinition>();
            HashSet<string> unmatched = new HashSet<string>();
            Dictionary<string, List<string>> multiMatch = new Dictionary<string, List<string>>();
            using (ModuleDefinition module1 = ModuleDefinition.ReadModule(args[0]))
            using (ModuleDefinition module2 = ModuleDefinition.ReadModule(args[1]))
            {
                foreach (TypeDefinition type1 in module1.GetTypes())
                {
                    if (type1.IsNested || type1.IsEnum)
                    {
                        continue;
                    }
                    List<TypeDefinition> matching = module2.GetTypes().Where(type2 => TypesAreEqual(type1, type2)).ToList();
                    if (matching.Count == 1)
                    {
                        equivalences[type1] = matching[0];
                    }
                    else if (matching.Count == 0)
                    {
                        // Don't bother with types that have a HandleRef field, those are Steam-related and won't be present in other editions.
                        if (type1.Fields.Count == 0 || type1.Fields[0].FieldType.FullName != "System.Runtime.InteropServices.HandleRef")
                        {
                            unmatched.Add(type1.FullName);
                        }
                    }
                    else
                    {
                        multiMatch.Add(type1.FullName, matching.Select(t => t.FullName).ToList());
                    }
                }
            }
            using (StreamWriter output = new StreamWriter(args[2]))
            {
                bool first = true;
                output.WriteLine("new Dictionary<string, TypeMapping>() {");
                foreach (KeyValuePair<TypeDefinition, TypeDefinition> equivalence in equivalences)
                {
                    if (!first)
                    {
                        output.WriteLine(",");
                    }
                    TypeDefinition sourceType = equivalence.Key;
                    TypeDefinition targetType = equivalence.Value;
                    output.WriteLine(string.Format("    [\"{0}\"] = new TypeMapping() {{", sourceType.FullName));
                    output.WriteLine(string.Format("        typeName = \"{0}\",", targetType.FullName));
                    output.WriteLine("        fieldEquivalences = new Dictionary<string, string>() {");
                    for (int i = 0; i < sourceType.Fields.Count; i++)
                    {
                        output.WriteLine(string.Format("            [\"{0}\"] = \"{1}\"{2}", sourceType.Fields[i].Name, targetType.Fields[i].Name, (i == sourceType.Fields.Count - 1) ? "" : ","));
                    }
                    output.WriteLine("        },");
                    output.WriteLine("        methodEquivalences = new Dictionary<string, string>() {");
                    for (int i = 0; i < sourceType.Methods.Count; i++)
                    {
                        output.WriteLine(string.Format("            [\"{0}\"] = \"{1}\"{2}", sourceType.Methods[i].Name, targetType.Methods[i].Name, (i == sourceType.Methods.Count - 1) ? "" : ","));
                    }
                    output.WriteLine("        }");
                    output.Write("    }");
                    first = false;
                }
                output.WriteLine();
                output.WriteLine(string.Format("// Unmatched top-level non-enum types: {0}", string.Join(", ", unmatched)));
                output.WriteLine();
                output.WriteLine("// Top-level non-enum types with more than one potential match:");
                foreach (KeyValuePair<string, List<string>> multiMatchPair in multiMatch)
                {
                    output.WriteLine(string.Format("// {0} : {1}", multiMatchPair.Key, string.Join(", ", multiMatchPair.Value)));
                }
                output.WriteLine("}");
            }
        }
    }
}
