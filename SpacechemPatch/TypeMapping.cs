using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch
{
    internal class TypeMapping
    {
        public string typeName;
        public Dictionary<string, string> fieldEquivalences;
        public Dictionary<string, string> methodEquivalences;
        public Dictionary<string, TypeMapping> nestedTypeEquivalences = new Dictionary<string, TypeMapping>();
    }
}
