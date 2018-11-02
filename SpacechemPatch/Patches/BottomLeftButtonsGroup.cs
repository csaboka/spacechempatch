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

        [Replaced("#=qWQOaP3dOJorpHmmJjSLdeA==", Patch.SuperFastForward)]
        private void SlowSpeedIf(bool active)
        {
            SetSpeedIf(SimulatorSpeed.Slow, active);
        }

        [Replaced("#=qPjHU2DKU481_78OpmYgWKw==", Patch.SuperFastForward)]
        private void MediumSpeedIf(bool active)
        {
            SetSpeedIf(SimulatorSpeed.Medium, active);
        }

        [Replaced("#=qoX67tNBq6rVeIST0_p9qLQ==", Patch.SuperFastForward)]
        private void FastSpeedIf(bool active)
        {
            SetSpeedIf(SimulatorSpeed.Fast, active);
        }

        [Replaced("#=qKuh4p5czvINuecfirp9O2g==", Patch.SuperFastForward)]
        private void RealtimeSpeedIf(bool active)
        {
            SetSpeedIf(GameScreen.GetTopmostScreenWithType<DefensePuzzle>() != null ? SimulatorSpeed.DefenseRealtime : SimulatorSpeed.Realtime, active);
        }

        [Injected]
        private void SetSpeedIf(SimulatorSpeed speed, bool active)
        {
            if (active)
            {
                if (KeyboardHelper.IsControlPressed())
                {
                    speed = SimulatorSpeed.SuperFastForward;
                }
                SimulationGlobals.SetSimulatorSpeed(speed);
                selectedSpeed = speed;
            }
        }
    }
}
