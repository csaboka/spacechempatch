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
        private static readonly string[] PATCHER_ATTRIBUTE_NAMES = { "DecoyAttribute", "ReplacedAttribute", "InjectedAttribute" };

        private readonly ModuleDefinition source;
        private readonly ModuleDefinition target;
        private readonly ModuleDefinition[] libraries;

        private readonly Dictionary<string, TypeReference> typeReplacements = new Dictionary<string, TypeReference>();
        private readonly Dictionary<string, MethodReference> methodReplacements = new Dictionary<string, MethodReference>();
        private readonly Dictionary<string, FieldReference> fieldReplacements = new Dictionary<string, FieldReference>();

        private TypeDefinition originalType;

        public Patcher(ModuleDefinition source, ModuleDefinition target, params ModuleDefinition[] libraries)
        {
            this.source = source;
            this.target = target;
            this.libraries = libraries;
        }

        private static IEnumerable<KeyValuePair<T, CustomAttribute>> FindAnnotated<T>(IEnumerable<T> source, params string[] attributeNames) where T : ICustomAttributeProvider
        {
            return from elem in source
                   from attribute in elem.CustomAttributes
                   where attributeNames.Contains(attribute.AttributeType.Name)
                   select new KeyValuePair<T, CustomAttribute>(elem, attribute);
        }

        private static bool IsAttributePresent(ICustomAttributeProvider element, string attributeName)
        {
            return element.CustomAttributes.Any(attribute => attribute.AttributeType.Name == attributeName);
        }

        private static T GetAttributeFieldValue<T>(CustomAttribute attribute, string fieldName, T fallback = default(T))
        {
            return attribute.Fields.Where(field => field.Name == fieldName).Select(field => (T)field.Argument.Value).DefaultIfEmpty(fallback).First();
        }

        private delegate TypeDefinition TypeFinder(string @namespace, string typeName);

        private void CollectReplacementsForTypes(IEnumerable<TypeDefinition> typeDefinitions, TypeFinder typeFinder)
        {
            foreach (KeyValuePair<TypeDefinition, CustomAttribute> typePair in FindAnnotated(typeDefinitions, "DecoyAttribute"))
            {
                TypeDefinition type = typePair.Key;
                CustomAttribute decoyAttribute = typePair.Value;
                string @namespace = GetAttributeFieldValue(decoyAttribute, "namespace", "");
                string scrambledName = (string)decoyAttribute.ConstructorArguments[0].Value;
                TypeDefinition targetType = typeFinder(@namespace, scrambledName);
                typeReplacements.Add(type.FullName, target.ImportReference(targetType));

                CollectMethodReplacementsInType(type, targetType);
                CollectFieldReplacementsInType(type, targetType);

                // Recurse for nested types.
                CollectReplacementsForTypes(type.NestedTypes, (dummy, typeName) => targetType.NestedTypes.First(t => t.Name == typeName));
            }
        }

        private void CollectMethodReplacementsInType(TypeDefinition sourceType, TypeDefinition targetType)
        {
            foreach (KeyValuePair<MethodDefinition, CustomAttribute> methodPair in FindAnnotated(sourceType.Methods, "ReplacedAttribute", "DecoyAttribute"))
            {
                MethodDefinition decoyMethod = methodPair.Key;
                CustomAttribute decoyMethodAttribute = methodPair.Value;
                string targetMethodName = (string)decoyMethodAttribute.ConstructorArguments[0].Value;
                MethodDefinition targetMethod = targetType.Methods.First(method => method.Name == targetMethodName && method.Parameters.Count == decoyMethod.Parameters.Count);
                methodReplacements.Add(decoyMethod.FullName, target.ImportReference(targetMethod));
            }
        }

        private void CollectFieldReplacementsInType(TypeDefinition sourceType, TypeDefinition targetType)
        {
            foreach (KeyValuePair<FieldDefinition, CustomAttribute> fieldPair in FindAnnotated(sourceType.Fields, "DecoyAttribute"))
            {
                FieldDefinition decoyField = fieldPair.Key;
                CustomAttribute decoyFieldAttribute = fieldPair.Value;
                string scrambledFieldName = (string)decoyFieldAttribute.ConstructorArguments[0].Value;
                FieldDefinition targetField = targetType.Fields.First(field => field.Name == scrambledFieldName);
                fieldReplacements.Add(decoyField.FullName, target.ImportReference(targetField));
            }
        }

        private void CollectReplacements()
        {
            CollectReplacementsForTypes(source.Types, FindTypeDefinition);
        }

        private TypeDefinition FindTypeDefinition(string @namespace, string name)
        {
            TypeDefinition targetDef = target.GetType(@namespace, name);
            if (targetDef != null)
            {
                return targetDef;
            }
            foreach (ModuleDefinition library in libraries)
            {
                TypeDefinition libraryDef = library.GetType(@namespace, name);
                if (libraryDef != null)
                {
                    return libraryDef;
                }
            }
            return null;
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
            // We already have the list of types we should check for replacement methods, it's the contents of
            // typeReplacements. This dictionary will be modified during fixups, though, so to keep things
            // consistent, iterate on a copy instead of the field itself.
            Dictionary<string, TypeReference> typeReplacementsCopy = new Dictionary<string, TypeReference>(typeReplacements);
            foreach (KeyValuePair<string, TypeReference> nameAndTargetPair in typeReplacementsCopy)
            {
                TypeDefinition decoyType = source.GetType(nameAndTargetPair.Key);
                TypeDefinition targetType = nameAndTargetPair.Value as TypeDefinition;
                if (targetType != null)
                {
                    // We can only have replacement methods when the target of the parent type
                    // is inside SpacheChem.exe, and therefore is a method definition, not a reference.
                    ReplaceMethodsOnType(decoyType, targetType, enabledPatches);
                }
            }
        }

        private void ReplaceMethodsOnType(TypeDefinition decoyType, TypeDefinition targetType, IEnumerable<Patch> enabledPatches)
        {
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
                    if (GetAttributeFieldValue(replacedAttribute, "KeepOriginal", false))
                    {
                        SaveOriginalMethod(replacementMethod, targetMethod, replacedAttribute);
                    }
                    ReplaceMethod(replacementMethod, targetMethod);
                }
            }
        }

        private void SaveOriginalMethod(MethodDefinition replacementMethod, MethodDefinition originalMethod, CustomAttribute replacedAttribute)
        {
            MethodDefinition copy = CopyMethod(originalMethod);
            string newName = GetAttributeFieldValue<string>(replacedAttribute, "NewNameForOriginal");
            if (newName == null)
            {
                copy.Parameters.Add(new ParameterDefinition("dummy", ParameterAttributes.None, originalType));
                replacementMethod.Parameters.Add(new ParameterDefinition("dummy", ParameterAttributes.None, originalType));
                methodReplacements.Add(replacementMethod.FullName, copy);
                replacementMethod.Parameters.RemoveAt(replacementMethod.Parameters.Count - 1);
            }
            else
            {
                copy.Name = newName;
                copy.IsRuntimeSpecialName = false;
                string originalName = replacementMethod.Name;
                replacementMethod.Name = newName;
                methodReplacements.Add(replacementMethod.FullName, copy);
                replacementMethod.Name = originalName;
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
            CopyCustomAttributes(source, newMethod);
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
                return FixupGenericInstanceMethod((GenericInstanceMethod)method);
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
                }
                else if (method is MethodDefinition && IsAttributePresent((MethodDefinition)method, "InjectedAttribute"))
                {
                    method = InjectMethod((MethodDefinition)method);
                }
            }
            else
            {
                method = replaced;
            }
            if (!(method is MethodDefinition))
            {
                method = target.ImportReference(method);
            }
            return method;
        }

        private MethodReference FixupGenericInstanceMethod(GenericInstanceMethod genericMethod)
        {
            GenericInstanceMethod fixedUp = new GenericInstanceMethod(FixupMethod(genericMethod.ElementMethod));
            foreach (TypeReference genericArgument in genericMethod.GenericArguments)
            {
                fixedUp.GenericArguments.Add(FixupType(genericArgument));
            }
            return fixedUp;
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
            if (replaced == null && field is FieldDefinition && IsAttributePresent((FieldDefinition)field, "InjectedAttribute"))
            {
                return InjectField((FieldDefinition)field);
            }
            return replaced ?? field;
        }

        private FieldReference InjectField(FieldDefinition field)
        {
            TypeDefinition targetType = (TypeDefinition)typeReplacements[field.DeclaringType.FullName];
            TypeReference fixedUpFieldType = FixupType(field.FieldType);
            FieldDefinition newField = new FieldDefinition(field.Name, field.Attributes, fixedUpFieldType);
            CopyCustomAttributes(field, newField);
            targetType.Fields.Add(newField);
            fieldReplacements[field.FullName] = newField;
            return newField;
        }

        private void CopyCustomAttributes(ICustomAttributeProvider source, ICustomAttributeProvider target)
        {
            foreach (CustomAttribute sourceAttribute in source.CustomAttributes)
            {
                if (PATCHER_ATTRIBUTE_NAMES.Contains(sourceAttribute.AttributeType.Name))
                {
                    continue;
                }
                CustomAttribute targetAttribute = new CustomAttribute(FixupMethod(sourceAttribute.Constructor));
                foreach (CustomAttributeArgument sourceArgument in sourceAttribute.ConstructorArguments)
                {
                    targetAttribute.ConstructorArguments.Add(FixupCustomAttributeArgument(sourceArgument));
                }
                foreach (CustomAttributeNamedArgument field in sourceAttribute.Fields)
                {
                    targetAttribute.Fields.Add(FixupCustomAttributeNamedArgument(field));
                }
                foreach (CustomAttributeNamedArgument property in sourceAttribute.Properties)
                {
                    targetAttribute.Properties.Add(FixupCustomAttributeNamedArgument(property));
                }
                target.CustomAttributes.Add(targetAttribute);
            }
        }

        private CustomAttributeArgument FixupCustomAttributeArgument(CustomAttributeArgument source)
        {
            TypeReference resultType = FixupType(source.Type);
            object resultValue = FixupAttributeValue(source.Value);
            return new CustomAttributeArgument(resultType, resultValue);
        }

        private CustomAttributeNamedArgument FixupCustomAttributeNamedArgument(CustomAttributeNamedArgument source)
        {
            return new CustomAttributeNamedArgument(source.Name, FixupCustomAttributeArgument(source.Argument));
        }

        private object FixupAttributeValue(object sourceValue)
        {
            if (sourceValue is CustomAttributeArgument[])
            {
                return ((CustomAttributeArgument[])sourceValue)
                    .Select(FixupCustomAttributeArgument)
                    .ToArray();
            }
            else if (sourceValue is TypeReference)
            {
                return FixupType((TypeReference)sourceValue);
            }
            else
            {
                return sourceValue;
            }
        }

    }
}
