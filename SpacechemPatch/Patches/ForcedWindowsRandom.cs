using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Injected(Patches = new Patch[] { Patch.ForceWindowsMoleculeOrder })]
    class ForcedWindowsRandom : AbstractForcedRandom
    {
        public ForcedWindowsRandom(int seed) : base(seed, 21)
        {

        }
    }
}
