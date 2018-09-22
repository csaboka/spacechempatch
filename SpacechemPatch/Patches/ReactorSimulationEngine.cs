using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=q8Is8RtfrAzqsMWBLpfh4XewZnZ285kIdE5Zote6JdoCJJ6fdL8gXhqVPW9IX7qNH")]
    internal sealed class ReactorSimulationEngine
    {
        [Decoy(".ctor")]
        public ReactorSimulationEngine(Reactor reactor)
        {
        }

        [Replaced("#=qhuLH3W6G8OouJ4C7pmV0hA==", Patch.StricterCollisionChecks, KeepOriginal = true, NewNameForOriginal = "OriginalDoCollisionChecks")]
        public void DoCollisionChecks()
        {
            // Don't bother with duplicate checks if the simulation is already paused because of an earlier collision.
            if (SimulationGlobals.GetRunState() == RunState.Running)
            {
                OriginalDoCollisionChecks();
            }
        }

        public void OriginalDoCollisionChecks()
        {
        }
    }
}
