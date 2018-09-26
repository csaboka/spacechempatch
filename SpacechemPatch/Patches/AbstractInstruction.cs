using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qCh9VWZ5rtqIQM5A0tHFVLUBdparU2HUoR8nCmvBY_NM=")]
    internal abstract class AbstractInstruction : ReactorMember
    {
        [Injected]
        protected void ForceCollisionCheck()
        {
            ownerReactor.reactorScreen.simulationEngine.DoForcedCollisionChecks();
        }

        [Decoy("#=qIURk5R1i5M$y_uNmDTNhPQ==")]
        public virtual Direction Activate(Waldo waldo)
        {
            return Direction.None;
        }
    }
}
