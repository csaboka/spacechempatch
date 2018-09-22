using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qOCff0FMp6HLIJiin8tAPOs8YzSkhvTUQ2CQafDRjcHs=")]
    class SimulationGlobals
    {
        [Decoy("#=qiJEVeNpgE3SzfB6flblo$Q==")]
        public static float partialCycle;

        [Decoy("#=qlrlsVc2m2To5$LC_pd0kjQ==")]
        public static void SetSimulatorSpeed(SimulatorSpeed newSpeed)
        {
        }
        [Decoy("#=q$Ny1aQDzjuVBPAZI$vtgEw==")]
        public static RunState GetRunState()
        {
            return RunState.Stopped;
        }
        [Decoy("#=qQ3mOqdihhsB6qb23lBtIbw==")]
        public static void SetRunState(RunState newRunState)
        {
        }
    }
}
