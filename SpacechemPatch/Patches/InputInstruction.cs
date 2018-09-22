using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qoinRHCGTiQixtVtIh0H07yWk_nNdyBrOGhz8ILY2PSRS5jaTYN1Cehgw_BItc122")]
    internal sealed class InputInstruction : AbstractInstruction
    {
        [Replaced("#=qIURk5R1i5M$y_uNmDTNhPQ==", Patch.StricterCollisionChecks, KeepOriginal = true, NewNameForOriginal = "OriginalActivate")]
        public override Direction Activate(Waldo waldo)
        {
            Direction result = OriginalActivate(waldo);
            ForceCollisionCheck();
            return result;
        }

        public Direction OriginalActivate(Waldo waldo)
        {
            return Direction.None;
        }
    }
}
