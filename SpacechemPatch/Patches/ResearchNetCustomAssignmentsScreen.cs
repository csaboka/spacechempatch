using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qNrFkie8CTHjmKDcRNuKwhKTiMeJ4C45qTEzBrELLp8cs336qms7yCnndRgd29_XN")]
    sealed class ResearchNetCustomAssignmentsScreen
    {
        [Decoy("#=qEfJUQTrb5BIPMcfeiEMtfw==")]
        private int currentScreen;

        [Decoy("#=qH71NcED8z$kY0CXuc6xEh3kPtOfYXIki_PCMtJvxEqg=")]
        public bool selectLast;

        [Decoy("#=q7Dcg6DJemxUOENjdrUQP5LtfgYofyR6sfBL3cbg6RHA=")]
        private List<CustomResNetPuzzleButton> visiblePuzzles;

        [Replaced("#=qTGDid3mjkUF8q6Z8N_OOUw==", Patch.ReverseOrderCustomResNetAssignments, KeepOriginal = true, NewNameForOriginal = "OriginalBuildUi")]
        protected AbstractUiElement BuildUi()
        {
            // Normally, the selectLast flag indicates that a new element was just added to the end
            // of the list and should be selected. Now that we've reversed the list, new elements
            // are added to the beginning. We neuter the regular processing by forcing the flag
            // to false, and compensate by selecting the first screen, then selecting the first
            // entry once the original has finished building the screen.
            bool savedSelectLast = selectLast;
            selectLast = false;
            if (savedSelectLast)
            {
                currentScreen = 0;
            }
            AbstractUiElement result = OriginalBuildUi();
            if (savedSelectLast)
            {
                visiblePuzzles.First().SetSelected(true);
                // This method is called by the original, but now that we've changed the
                // selection, it must be called again to make sure the right buttons
                // are enabled.
                UpdateEnabledStateOfButtons();
            }
            return result;
        }

        protected AbstractUiElement OriginalBuildUi()
        {
            return null;
        }

        [Decoy("#=qcGnoqBcegikyQ1DA65t5$_sTw_KyudlA9itv$d88fTY=")]
        private void UpdateEnabledStateOfButtons()
        {

        }
    }
}
