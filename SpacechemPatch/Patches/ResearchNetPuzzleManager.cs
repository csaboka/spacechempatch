using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=q9k7Bnj$0OBzRFHk2irpOQ3c9EtF46VzE5P_gsDLRPyDxji4Qeh_Z_YkVbTIw7l7_")]
    sealed class ResearchNetPuzzleManager
    {
        [Decoy("#=qHwCDMuNC1JLVlCRXIX6Lfg==")]
        public sealed class PersistedPuzzleDefinition
        {

        }

        [Replaced("#=qBgcFTjnt7reIBAuELET1fw==", Patch.ReverseOrderCustomResNetAssignments, KeepOriginal = true, NewNameForOriginal = "OriginalGetCustomPuzzles")]
        public IEnumerable<PersistedPuzzleDefinition> GetCustomPuzzles()
        {
            return OriginalGetCustomPuzzles().Reverse();
        }

        public IEnumerable<PersistedPuzzleDefinition> OriginalGetCustomPuzzles()
        {
            return null;
        }
    }
}
