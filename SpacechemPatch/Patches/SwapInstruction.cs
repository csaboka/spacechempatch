using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=q6LuOO0mn6Dnnb0uSbunfd8q6uwX_zr1$Snj15$thTU3oIwB82JWzCIfvGh5gxIEf")]
    internal sealed class SwapInstruction : AbstractInstruction
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
