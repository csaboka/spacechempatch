using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch
{
    [AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
    class ReplacedAttribute : Attribute
    {
        private string scrambledName;
        public string ScrambledName
        {
            get {
                return scrambledName;
            }
        }

        private Patch[] patches;
        public Patch[] Patches
        {
            get
            {
                return (Patch[])patches.Clone();
            }
        }
        public bool KeepOriginal;

        public ReplacedAttribute(string scrambledName, params Patch[] patches)
        {
            this.scrambledName = scrambledName;
            this.patches = patches;
        }
    }
}
