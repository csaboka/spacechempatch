using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=q8Is8RtfrAzqsMWBLpfh4XewZnZ285kIdE5Zote6JdoCJJ6fdL8gXhqVPW9IX7qNH")]
    internal sealed class ReactorSimulationEngine
    {
        // This is a hack to allow skipping the first "normal" collision check while still being able to
        // do forced checks at the beginning of the cycle.
        [Injected]
        private bool forced;

        [Decoy(".ctor")]
        public ReactorSimulationEngine(Reactor reactor)
        {
        }

        [Injected]
        public void DoForcedCollisionChecks()
        {
            forced = true;
            DoCollisionChecks();
            forced = false;
        }

        [Replaced("#=qhuLH3W6G8OouJ4C7pmV0hA==", Patch.StricterCollisionChecks, KeepOriginal = true, NewNameForOriginal = "OriginalDoCollisionChecks")]
        public void DoCollisionChecks()
        {
            // We want to bypass the first "normal" check because we're forcing new ones that replace it.
            if (SimulationGlobals.partialCycle == 0 && !forced)
            {
                return;
            }
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
