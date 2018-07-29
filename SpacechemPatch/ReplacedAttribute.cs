using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpacechemPatch
{
    [AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
    class ReplacedAttribute : Attribute
    {
        private string scrambledName;

        public ReplacedAttribute(string scrambledName)
        {
            this.scrambledName = scrambledName;
        }
    }
}
