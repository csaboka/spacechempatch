using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Method)]
    class InjectedAttribute : Attribute
    {
        // This field should only be necessary when injecting enum constants.
        // For everything else, the patcher can automatically figure out
        // whether the field is being referenced by patch methods.
        public Patch[] Patches;
    }
}
