using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qviKeLKiONmznQRMq602nbFdmyT8Q07$td_dC55Hutfw=")]
    internal sealed class SensorFeature : AbstractFeature
    {
        [Decoy(".ctor")]
        public SensorFeature(Reactor reactor) :
            base(null, null, false, null, default(Vector2i))    // This is not the real super call, just here to make the compiler happy.
        {

        }
    }
}
