using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qm61udI5e9eXBbc6SfLdQV8XLfOnvNNF7wo86LmUnhyk=")]
    internal sealed class SplitterFeature : AbstractFeature
    {
        [Decoy(".ctor")]
        public SplitterFeature(Reactor reactor) :
            base(null, null, false, null, default(Vector2i))    // This is not the real super call, just here to make the compiler happy.
        {

        }

    }
}
