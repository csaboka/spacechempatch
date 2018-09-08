using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qywe$cmUus9b_zw2ErmgoI5LfmVAmB1w7NfLtjxaTDOs=")]
    internal sealed class FuserFeature : AbstractFeature
    {
        [Decoy(".ctor")]
        public FuserFeature(Reactor reactor) :
            base(null, null, false, null, default(Vector2i))    // This is not the real super call, just here to make the compiler happy.
        {

        }

    }
}
