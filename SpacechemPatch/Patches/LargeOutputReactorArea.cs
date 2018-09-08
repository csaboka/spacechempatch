using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qbVYiuFUiFv8DeuzGAXnnRxuTdfxzeNCIX7$CehSd03DrAwVAtHPJJcEdzhpKYRZJ")]
    internal sealed class LargeOutputReactorArea : ReactorScreen
    {
        [Decoy(".ctor")]
        public LargeOutputReactorArea(AbstractReactorType reactorType)
            : base(reactorType)
        {

        }
    }
}
