﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qmRKruzdPDMsXNhEp62qMReG6mf4FO6qI_QHkxfiyNk5F01P8jqqy6oBWleFKbp0z")]
    internal sealed class SplitInstruction : AbstractInstruction
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
