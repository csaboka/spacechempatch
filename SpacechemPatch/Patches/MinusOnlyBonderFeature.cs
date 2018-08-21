using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qRx7ZfPnU_oTBF0cGYkaGvuWAPvS478krajKgfxLowe72jz3UhMX6QvkfGxi6IxYe")]
    sealed class MinusOnlyBonderFeature : BonderFeature
    {
        [Decoy(".ctor")]
        public MinusOnlyBonderFeature(Reactor reactor) : base(reactor)
        {

        }
    }
}
