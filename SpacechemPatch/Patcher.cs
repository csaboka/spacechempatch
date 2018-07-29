using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mono.Cecil;
using Mono.Cecil.Cil;

namespace SpacechemPatch
{
    class Patcher
    {
        private readonly Dictionary<TypeReference, TypeReference> typeReplacements;
        private readonly Dictionary<MethodReference, MethodReference> methodReplacements;
        private readonly Dictionary<FieldReference, FieldReference> fieldReplacements;

        public Patcher (Dictionary<TypeReference, TypeReference> typeReplacements, Dictionary<MethodReference, MethodReference> methodReplacements, Dictionary<FieldReference, FieldReference> fieldReplacements)
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
            if (!(method is MethodDefinition))
            {
                method = targetModule.ImportReference(method);
            }
            MethodReference replaced;
            methodReplacements.TryGetValue(method, out replaced);
            return replaced ?? method;
        }

        private TypeReference FixupType(TypeReference type, ModuleDefinition targetModule)
        {
            if (type is GenericInstanceType)
            {
                return FixupGenericType((GenericInstanceType)type, targetModule);
            }
            if (!(type is TypeDefinition))
            {
                type = targetModule.ImportReference(type);
            }
            TypeReference replaced;
            typeReplacements.TryGetValue(type, out replaced);
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
            fieldReplacements.TryGetValue(field, out replaced);
            return replaced ?? field;
        }
    }
}
