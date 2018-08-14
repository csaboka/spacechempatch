using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mono.Cecil;
using Mono.Cecil.Cil;

namespace SpacechemPatch
{
    class Patcher
    {
        private readonly ModuleDefinition source;
        private readonly ModuleDefinition target;

        private readonly Dictionary<string, TypeReference> typeReplacements = new Dictionary<string, TypeReference>();
        private readonly Dictionary<string, MethodReference> methodReplacements = new Dictionary<string, MethodReference>();
        private readonly Dictionary<string, FieldReference> fieldReplacements = new Dictionary<string, FieldReference>();

        private TypeDefinition originalType;

        public Patcher (ModuleDefinition source, ModuleDefinition target)
        {
            this.source = source;
            this.target = target;
        }

        private static IEnumerable<KeyValuePair<T, CustomAttribute>> FindAnnotated<T>(IEnumerable<T> source, params string[] attributeNames) where T : ICustomAttributeProvider
        {
            return from elem in source
                   from attribute in elem.CustomAttributes
                   where attributeNames.Contains(attribute.AttributeType.Name)
                   select new KeyValuePair<T, CustomAttribute>(elem, attribute);
        }

        private delegate TypeDefinition TypeFinder(string @namespace, string typeName);

        private void CollectReplacementsForTypes(IEnumerable<TypeDefinition> typeDefinitions, TypeFinder typeFinder)
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
                    MethodDefinition targetMethod = targetType.Methods.First(method => method.Name == targetMethodName && method.Parameters.Count == decoyMethod.Parameters.Count);
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
                CollectReplacementsForTypes(type.NestedTypes, (dummy, typeName) => targetType.NestedTypes.First(t => t.Name == typeName));
            }
        }

        private void CollectReplacements()
        {
            CollectReplacementsForTypes(source.Types, target.GetType);
        }

        private void InitOriginalType()
        {
            TypeDefinition originalInSource = source.GetType("SpacechemPatch", "Original");
            originalType = new TypeDefinition(originalInSource.Namespace, originalInSource.Name, originalInSource.Attributes);
            originalType.BaseType = target.TypeSystem.Object;
            originalType.Fields.Add(new FieldDefinition("INSTANCE", FieldAttributes.Public | FieldAttributes.Static, originalType));
            target.Types.Add(originalType);
            typeReplacements.Add(originalInSource.FullName, originalType);
            fieldReplacements.Add(originalInSource.Fields[0].FullName, originalType.Fields[0]);
        }

        public void ApplyPatches(IEnumerable<Patch> enabledPatches)
        {
            InitOriginalType();
            CollectReplacements();
            foreach (KeyValuePair<TypeDefinition, CustomAttribute> decoyPair in FindAnnotated(source.Types, "DecoyAttribute"))
            {
                TypeDefinition decoyType = decoyPair.Key;
                CustomAttribute decoyAttribute = decoyPair.Value;
                string @namespace = "";
                if (decoyAttribute.Fields.Count != 0)
                {
                    @namespace = (string)decoyAttribute.Fields.First(field => field.Name == "namespace").Argument.Value;
                }
                string scrambledName = (string)decoyAttribute.ConstructorArguments[0].Value;
                TypeDefinition targetType = target.GetType(@namespace, scrambledName);

                foreach (KeyValuePair<MethodDefinition, CustomAttribute> methodPair in FindAnnotated(decoyType.Methods, "ReplacedAttribute"))
                {
                    MethodDefinition replacementMethod = methodPair.Key;
                    CustomAttribute replacedAttribute = methodPair.Value;
                    string scrambledMethodName = (string)replacedAttribute.ConstructorArguments[0].Value;
                    IEnumerable<Patch> patchesToEnableFor = from attrib in replacedAttribute.ConstructorArguments[1].Value as CustomAttributeArgument[]
                                                            select (Patch)attrib.Value;
                    if (patchesToEnableFor.Count() == 0 || patchesToEnableFor.Any(patch => enabledPatches.Contains(patch)))
                    {
                        MethodDefinition targetMethod = targetType.Methods.First(method => method.Name == scrambledMethodName && method.Parameters.Count == replacementMethod.Parameters.Count);
                        if (replacedAttribute.Fields.Any(field => field.Name == "KeepOriginal" && (bool)field.Argument.Value))
                        {
                            MethodDefinition copy = CopyMethod(targetMethod);
                            replacementMethod.Parameters.Add(new ParameterDefinition("dummy", ParameterAttributes.None, originalType));
                            methodReplacements.Add(replacementMethod.FullName, copy);
                            replacementMethod.Parameters.RemoveAt(replacementMethod.Parameters.Count - 1);
                        }
                        ReplaceMethod(replacementMethod, targetMethod);
                    }
                }
            }
        }

        private void ReplaceMethod(MethodDefinition source, MethodDefinition target)
        {
            MethodBody body = target.Body;
            body.Instructions.Clear();
            foreach (var instruction in source.Body.Instructions)
            {
                body.Instructions.Add(FixupInstruction(instruction));
            }
            body.Variables.Clear();
            foreach (var variable in source.Body.Variables)
            {
                variable.VariableType = FixupType(variable.VariableType);
                body.Variables.Add(variable);
            }
            body.ExceptionHandlers.Clear();
            foreach (var exHandler in source.Body.ExceptionHandlers)
            {
                body.ExceptionHandlers.Add(exHandler);
            }
        }

        private MethodDefinition CopyMethod(MethodDefinition method)
        {
            MethodDefinition copy = new MethodDefinition(method.Name, method.Attributes, method.ReturnType);
            // Make sure the copy isn't virtual - we don't want subclasses to accidentally override it.
            copy.IsNewSlot = true;
            copy.IsVirtual = false;
            foreach (ParameterDefinition parameterDef in method.Parameters)
            {
                copy.Parameters.Add(parameterDef);
            }
            copy.Parameters.Add(new ParameterDefinition("dummy", ParameterAttributes.None, originalType));
            foreach (var instruction in method.Body.Instructions)
            {
                copy.Body.Instructions.Add(instruction);
            }
            foreach (var variable in method.Body.Variables)
            {
                copy.Body.Variables.Add(variable);
            }
            foreach (var exHandler in method.Body.ExceptionHandlers)
            {
                copy.Body.ExceptionHandlers.Add(exHandler);
            }
            method.DeclaringType.Methods.Add(copy);
            return copy;
        }

        private MethodDefinition InjectMethod(MethodDefinition source)
        {
            TypeDefinition targetType = (TypeDefinition)typeReplacements[source.DeclaringType.FullName];
            MethodDefinition newMethod = new MethodDefinition(source.Name, source.Attributes, FixupType(source.ReturnType));
            foreach (ParameterDefinition parameterDef in source.Parameters)
            {
                ParameterDefinition newParameter = new ParameterDefinition(parameterDef.Name, parameterDef.Attributes, FixupType(parameterDef.ParameterType));
                newParameter.Constant = parameterDef.Constant;
                newMethod.Parameters.Add(newParameter);
            }
            // The method might make a recursive call to itself, so we need the method added to the replacements
            // before we start fixing up instructions.
            methodReplacements.Add(source.FullName, newMethod);
            foreach (var instruction in source.Body.Instructions)
            {
                newMethod.Body.Instructions.Add(FixupInstruction(instruction));
            }
            foreach (var variable in source.Body.Variables)
            {
                newMethod.Body.Variables.Add(new VariableDefinition(FixupType(variable.VariableType)));
            }
            foreach (var exceptionHandler in source.Body.ExceptionHandlers)
            {
                newMethod.Body.ExceptionHandlers.Add(exceptionHandler);
            }
            targetType.Methods.Add(newMethod);
            return newMethod;
        }

        private Instruction FixupInstruction(Instruction instruction)
        {
            if (instruction.Operand is TypeReference)
            {
                return Instruction.Create(instruction.OpCode, FixupType((TypeReference)instruction.Operand));
            }
            if (instruction.Operand is MethodReference)
            {
                return Instruction.Create(instruction.OpCode, FixupMethod((MethodReference)instruction.Operand));
            }
            if (instruction.Operand is FieldReference)
            {
                return Instruction.Create(instruction.OpCode, FixupField((FieldReference)instruction.Operand));
            }
            return instruction;
        }

        private MethodReference FixupMethod(MethodReference method)
        {
            if (method is GenericInstanceMethod)
            {
                GenericInstanceMethod genericMethod = (GenericInstanceMethod)method;
                GenericInstanceMethod fixedUp = new GenericInstanceMethod(FixupMethod(genericMethod.ElementMethod));
                foreach (TypeReference genericArgument in genericMethod.GenericArguments)
                {
                    fixedUp.GenericArguments.Add(FixupType(genericArgument));
                }
                return fixedUp;
            }
            MethodReference replaced;
            methodReplacements.TryGetValue(method.FullName, out replaced);
            if (replaced == null)
            {
                if (method.ReturnType is GenericInstanceType || method.DeclaringType is GenericInstanceType)
                {
                    string oldFullName = method.FullName;
                    method.ReturnType = FixupType(method.ReturnType);
                    method.DeclaringType = FixupType(method.DeclaringType);
                    // Avoid repeated fixups of this instance by mapping the changed type to itself in the replacement map.
                    // Map it to its old name, too, so if a different instance with the exact same signature is encountered, we don't need to process it again.
                    methodReplacements.Add(method.FullName, method);
                    methodReplacements.Add(oldFullName, method);
                } else if (method is MethodDefinition && ((MethodDefinition)method).CustomAttributes.Any(attribute => attribute.AttributeType.Name == "InjectedAttribute"))
                {
                    method = InjectMethod((MethodDefinition)method);
                }
            } else
            {
                method = replaced;
            }
            if (!(method is MethodDefinition))
            {
                method = target.ImportReference(method);
            }
            return method;
        }

        private TypeReference FixupType(TypeReference type)
        {
            if (type is GenericInstanceType)
            {
                return FixupGenericType((GenericInstanceType)type);
            }
            if (type is GenericParameter)
            {
                return type;
            }
            if (!(type is TypeDefinition))
            {
                type = target.ImportReference(type);
            }
            TypeReference replaced;
            typeReplacements.TryGetValue(type.FullName, out replaced);
            type = replaced ?? type;
            return type;
        }

        private TypeReference FixupGenericType(GenericInstanceType type)
        {
            TypeReference elementType = FixupType(type.ElementType);
            GenericInstanceType newType = new GenericInstanceType(elementType);
            foreach (TypeReference genericArg in type.GenericArguments)
            {
                newType.GenericArguments.Add(FixupType(genericArg));
            }
            return target.ImportReference(newType);
        }

        private FieldReference FixupField(FieldReference field)
        {
            FieldReference replaced;
            fieldReplacements.TryGetValue(field.FullName, out replaced);
            if (replaced == null && field is FieldDefinition && ((FieldDefinition)field).CustomAttributes.Any(attr => attr.AttributeType.Name == "InjectedAttribute"))
            {
                FieldDefinition fieldDefinition = (FieldDefinition)field;
                TypeDefinition targetType = (TypeDefinition)typeReplacements[fieldDefinition.DeclaringType.FullName];
                TypeReference fixedUpFieldType = FixupType(fieldDefinition.FieldType);
                FieldDefinition newField = new FieldDefinition(fieldDefinition.Name, fieldDefinition.Attributes, fixedUpFieldType);
                targetType.Fields.Add(newField);
                fieldReplacements[field.FullName] = newField;
                return newField;
            }
            return replaced ?? field;
        }
    }
}
