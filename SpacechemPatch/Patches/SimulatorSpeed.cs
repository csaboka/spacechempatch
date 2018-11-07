using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("SimulatorSpeed", @namespace = "SpaceChem")]
    internal enum SimulatorSpeed : short
    {
        Slow = 2,
        Medium = 5,
        Fast = 15, // 0x000F
        DefenseRealtime = 200, // 0x00C8
        Realtime = 400, // 0x0190
        [Injected(Patches = new Patch[] { Patch.SuperFastForward })]
        SuperFastForward = 32767   //0x7FFF
    }
}
