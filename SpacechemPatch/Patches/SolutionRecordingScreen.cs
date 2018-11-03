using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qmYbaTK$qDSiMDRUe5TH7t4n4sXnPoqcIBAtkOsSPhR8=")]
    internal sealed class SolutionRecordingScreen : IScreen
    {
        [Decoy("#=qNlt3wxwmjko9S5CtwXWVNA==")]
        private CapturedVideo currentlyCapturedVideo;
        [Decoy("#=qi4GVWyRA81_9rSbY3jCc5g==")]
        private Score score;

        [Replaced("#=qj4QvilyKPDKh5rzkxc5cVR0CQHjvQdEBebUNswBYEONKCedCEdnwgZuwAB9sP71T", Patch.RemoveYouTubeUpload)]
        private void OnRecordingComplete()
        {
            SimulationGlobals.SetRunState(RunState.Stopped);
            Constants.spaceChemGame.StopVideoCapture();
            // Instead of properly showing the destination dialog, just instantiate it and pretend that
            // the Save to Desktop button was clicked on it.
            GameScreen.RemoveTopmostScreen();
            RecordingDestinationDialog destinationDialog = new RecordingDestinationDialog(currentlyCapturedVideo, score);
            destinationDialog.OnSaveToDesktopClickBackdoor();
        }
    }
}
