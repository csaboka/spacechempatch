using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Enum | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Method | AttributeTargets.Struct)]
    class DecoyAttribute : Attribute
    {
        private string scrambledName;
        public string @namespace = "";

        public DecoyAttribute(string scrambledName)
        {
            this.scrambledName = scrambledName;
        }
    }
}
