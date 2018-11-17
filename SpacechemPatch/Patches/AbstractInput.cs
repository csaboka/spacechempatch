using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qHJg2xw0fr7h0yuWckbuYE_bIzYF932S2B6k6hebkSdrXJ24WpXkGkM6FfoO7P_fg")]
    abstract class AbstractInput : AbstractDraggable, IEnumerable, IEnumerable<KeyValuePair<MoleculeDefinition, double>>
    {
        [Decoy("#=qse7XwupTBPPdxuy1VBotVQ==")]
        private int randomSeed;
        [Decoy("#=qlrkKlldnThqgfgucUWJ1Ow==")]
        private Random random;

        [Decoy("GetEnumerator")]
        public IEnumerator<KeyValuePair<MoleculeDefinition, double>> GetEnumerator()
        {
            return null;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return null;
        }

        [Replaced("#=qQ35xZz04iKhiXjOwE7un_g==", Patch.ForceLinuxMoleculeOrder, KeepOriginal = true, NewNameForOriginal = "OriginalReset")]
        public void ResetLinux()
        {
            OriginalReset();
            random = new ForcedLinuxRandom(randomSeed);
        }

        [Replaced("#=qQ35xZz04iKhiXjOwE7un_g==", Patch.ForceWindowsMoleculeOrder, KeepOriginal = true, NewNameForOriginal = "OriginalReset")]
        public void ResetWindows()
        {
            OriginalReset();
            random = new ForcedWindowsRandom(randomSeed);
        }

        private void OriginalReset()
        {

        }
    }
}
