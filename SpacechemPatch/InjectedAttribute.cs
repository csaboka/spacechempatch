using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Method)]
    class InjectedAttribute : Attribute
    {
    }
}
