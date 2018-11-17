using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Injected(Patches = new Patch[] { Patch.ForceLinuxMoleculeOrder })]
    class ForcedLinuxRandom : AbstractForcedRandom
    {
        public ForcedLinuxRandom(int seed) : base(seed, 31)
        {

        }

        public override int Next(int minValue, int maxValue)
        {
            // The old Mono code doesn't update the generator state when only one return value is valid.
            // We need to mimic this behavior to faithfully reproduce the Linux randomness.
            if (maxValue <= 1)
            {
                return 0;
            }
            else
            {
                return base.Next(minValue, maxValue);
            }
        }
    }
}
