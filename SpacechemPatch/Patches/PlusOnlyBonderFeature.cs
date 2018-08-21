using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=q5y3FY6n4K4qD_zbNUoqw$C8oqPAt01KzbzJktIjIMt$fKwUqNJWJr$xFP4eJfQgk")]
    sealed class PlusOnlyBonderFeature : BonderFeature
    {
        [Decoy(".ctor")]
        public PlusOnlyBonderFeature(Reactor reactor) : base(reactor)
        {

        }
    }
}
