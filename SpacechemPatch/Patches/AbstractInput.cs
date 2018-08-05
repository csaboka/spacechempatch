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
        [Decoy("GetEnumerator")]
        public IEnumerator<KeyValuePair<MoleculeDefinition, double>> GetEnumerator()
        {
            return null;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return null;
        }
    }
}
