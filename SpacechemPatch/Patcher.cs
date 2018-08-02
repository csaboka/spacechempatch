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
        private readonly Dictionary<string, TypeReference> typeReplacements;
        private readonly Dictionary<string, MethodReference> methodReplacements;
        private readonly Dictionary<string, FieldReference> fieldReplacements;

        public Patcher (Dictionary<string, TypeReference> typeReplacements, Dictionary<string, MethodReference> methodReplacements, Dictionary<string, FieldReference> fieldReplacements)
        {
            this.typeReplacements = typeReplacements;
            this.methodReplacements = methodReplacements;
            this.fieldReplacements = fieldReplacements;
        }

        public void ReplaceMethod(MethodDefinition source, MethodDefinition target)
        {
            MethodBody body = target.Body;
            body.Instructions.Clear();
            foreach (var instruction in source.Body.Instructions)
            {
                if (instruction.Operand != null)
                {
                    instruction.Operand = FixupOperand(instruction.Operand, target.Module);
                }
                body.Instructions.Add(instruction);
            }
            body.Variables.Clear();
            foreach (var variable in source.Body.Variables)
            {
                variable.VariableType = FixupType(variable.VariableType, target.Module);
                body.Variables.Add(variable);
            }
            body.ExceptionHandlers.Clear();
            foreach (var exHandler in source.Body.ExceptionHandlers)
            {
                body.ExceptionHandlers.Add(exHandler);
            }
        }

        private object FixupOperand(object operand, ModuleDefinition targetModule)
        {
            if (operand is TypeReference)
            {
                return FixupType((TypeReference)operand, targetModule);
            } else if (operand is MethodReference)
            {
                return FixupMethod((MethodReference)operand, targetModule);
            } else if (operand is FieldReference)
            {
                return FixupField((FieldReference)operand, targetModule);
            } else
            {
                return operand;
            }
        }

        private MethodReference FixupMethod(MethodReference method, ModuleDefinition targetModule)
        {
            MethodReference replaced;
            methodReplacements.TryGetValue(method.FullName, out replaced);
            if (replaced == null && (method.ReturnType is GenericInstanceType || method.DeclaringType is GenericInstanceType))
            {
                string oldFullName = method.FullName;
                method.ReturnType = FixupType(method.ReturnType, targetModule);
                method.DeclaringType = FixupType(method.DeclaringType, targetModule);
                // Avoid repeated fixups of this instance by mapping the changed type to itself in the replacement map.
                // Map it to its old name, too, so if a different instance with the exact same signature is encountered, we don't need to process it again.
                methodReplacements.Add(method.FullName, method);
                methodReplacements.Add(oldFullName, method);
            }
            method = replaced ?? method;
            if (!(method is MethodDefinition))
            {
                method = targetModule.ImportReference(method);
            }
            return method;
        }

        private TypeReference FixupType(TypeReference type, ModuleDefinition targetModule)
        {
            if (type is GenericInstanceType)
            {
                return FixupGenericType((GenericInstanceType)type, targetModule);
            }
            if (type is GenericParameter)
            {
                return type;
            }
            if (!(type is TypeDefinition))
            {
                type = targetModule.ImportReference(type);
            }
            TypeReference replaced;
            typeReplacements.TryGetValue(type.FullName, out replaced);
            type = replaced ?? type;
            /*foreach (GenericParameter param in type.GenericParameters)
            {
                for (int i=0; i<param.Constraints.Count; i++)
                {
                    param.Constraints[i] = FixupType(param.Constraints[i], targetModule);
                }
            }*/
            return type;
        }

        private TypeReference FixupGenericType(GenericInstanceType type, ModuleDefinition targetModule)
        {
            TypeReference elementType = FixupType(type.ElementType, targetModule);
            GenericInstanceType newType = new GenericInstanceType(elementType);
            foreach (TypeReference genericArg in type.GenericArguments)
            {
                newType.GenericArguments.Add(FixupType(genericArg, targetModule));
            }
            return targetModule.ImportReference(newType);
        }

        private FieldReference FixupField(FieldReference field, ModuleDefinition targetModule)
        {
            FieldReference replaced;
            fieldReplacements.TryGetValue(field.FullName, out replaced);
            if (replaced == null && field is FieldDefinition && ((FieldDefinition)field).CustomAttributes.Any(attr => attr.AttributeType.Name == "InjectedAttribute"))
            {
                FieldDefinition fieldDefinition = (FieldDefinition)field;
                TypeDefinition targetType = (TypeDefinition)typeReplacements[fieldDefinition.DeclaringType.FullName];
                TypeReference fixedUpFieldType = FixupType(fieldDefinition.FieldType, targetModule);
                FieldDefinition newField = new FieldDefinition(fieldDefinition.Name, fieldDefinition.Attributes, fixedUpFieldType);
                targetType.Fields.Add(newField);
                fieldReplacements[field.FullName] = newField;
                return newField;
            }
            return replaced ?? field;
        }
    }
}
