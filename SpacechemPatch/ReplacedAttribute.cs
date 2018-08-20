using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch
{
    [AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
    class ReplacedAttribute : Attribute
    {
        private readonly string scrambledName;
        private readonly Patch[] patches;
        public bool KeepOriginal;
        public string NewNameForOriginal;

        public ReplacedAttribute(string scrambledName, params Patch[] patches)
        {
            this.scrambledName = scrambledName;
            this.patches = patches;
        }
    }
}
