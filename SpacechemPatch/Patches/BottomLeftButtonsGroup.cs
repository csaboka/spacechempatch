using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qe6q0trBerH0MPeEiyQpYSkozMIBiQ0kpG_BDMb8m7tE=")]
    internal sealed class BottomLeftButtonsGroup
    {
        [Decoy("#=qgUNLK6tSfosHo2yDxXPYug==")]
        private SimulatorSpeed selectedSpeed;

        [Replaced("#=qKuh4p5czvINuecfirp9O2g==", Patch.SuperFastForward)]
        private void RealtimeSpeedIf(bool active)
        {
            if (!active)
            {
                return;
            }
            SimulatorSpeed speed = GameScreen.GetTopmostScreenWithType<DefensePuzzle>() != null ? SimulatorSpeed.DefenseRealtime : SimulatorSpeed.Realtime;
            if (KeyboardHelper.IsControlPressed())
            {
                speed = SimulatorSpeed.SuperFastForward;
            }
            SimulationGlobals.SetSimulatorSpeed(speed);
            selectedSpeed = speed;
        }
    }
}
