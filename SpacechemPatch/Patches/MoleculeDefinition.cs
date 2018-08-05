﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qG4fRLTF7VgPjIT82MmidAKaNZJLG$uA83rXzQGp40b0=")]
    class MoleculeDefinition
    {
        [Decoy("#=quY9YhhTOhinNRAlMHGe_BA==")]
        public Dictionary<Vector2i, Atom> atoms;
        [Decoy("#=qBePJmry0TzqLZdQMcgmrvQ==")]
        public Dictionary<PotentialBond, BondCount> bonds;

        [Decoy("#=qMte2gARWVWATIryhhstFwgRW9JVIdt$VnuS8gIMhh0w=")]
        class AtomDefinition
        {
            [Decoy("#=qtrjhr78JXu6d$kQfY7Fsqg==")]
            public Atom atom;
            [Decoy("#=qc3S6mAs1TOE_3QWOt0tLXQ==")]
            public List<BondDefinition> bonds;
            [Injected]
            public AtomDefinition proposedCounterpart;

            [Decoy("#=q8g9zLb_qi5zv_vYuh4Hn0Q==")]
            public List<AtomDefinition> GetBondedAtoms(BondCount bondCount)
            {
                return null;
            }

        }

        [Decoy("#=qLTbI8ygTeJm7wKqQHN1CmAIMJc3bt38WbrBXvJCjWOU=")]
        class BondDefinition
        {
            [Decoy("#=q8I31dseSEfqB1a3XAs73Ig==")]
            public BondCount bondCount;
            [Decoy("#=q435pjqyaHqnFovzWf9g_mA==")]
            public AtomDefinition atom1;
            [Decoy("#=qY60ztVRPK8HtMDj_Lgrhjg==")]
            public AtomDefinition atom2;

        }

        [Decoy("#=qTd598wTpL30A8GqUuGFkdhSGZcGtw8vhkCEuOPZjfj0=")]
        private static Dictionary<Vector2i, AtomDefinition> ToAtomDefinitions(MoleculeDefinition moleculeDefinition)
        {
            return null;
        }

        [Decoy("#=qBSpkp4g1gcs3G8qeUnlTEAvDsZNAXSZt0HFSUvl197U=")]
        private static bool IdenticalBonds(AtomDefinition atom1, AtomDefinition atom2)
        {
            return false;
        }

        [Replaced("#=qcAI4xoajB5c0nSHhfDrzAw==", Patch.FixWrongOutput)]
        public bool Matches(MoleculeDefinition other)
        {
            if (atoms.Count != other.atoms.Count || bonds.Count != other.bonds.Count)
                return false;
            Dictionary<Vector2i, AtomDefinition> dictionary1 = ToAtomDefinitions(this);
            Dictionary<Vector2i, AtomDefinition> dictionary2 = ToAtomDefinitions(other);
            foreach (AtomDefinition atomDefinition1 in dictionary1.Values)
            {
                foreach (AtomDefinition atomDefinition2 in dictionary2.Values)
                {
                    if (MoleculeMatchesRecursive(atomDefinition1, atomDefinition2))
                        return true;
                    // In case of partial match, the proposedCounterpart field of matched atoms
                    // is still filled out, so clean everything up before trying with a different starting pair.
                    foreach (AtomDefinition atomDefinition in dictionary1.Values)
                        atomDefinition.proposedCounterpart = null;
                    foreach (AtomDefinition atomDefinition in dictionary2.Values)
                        atomDefinition.proposedCounterpart = null;
                }
            }
            return false;
        }

        [Replaced("#=q1Vpe1ZE6Z0HVwO_GD01w8Q==", Patch.FixWrongOutput)]
        private static bool MoleculeMatchesRecursive(AtomDefinition atomDefinition1, AtomDefinition atomDefinition2)
        {
            // Make sure we don't match an atom that's already matched with something else. This check also prevents infinite
            // recursion when an atom is revisited by one of its neighbors.
            if (atomDefinition1.proposedCounterpart != null || atomDefinition2.proposedCounterpart != null)
            {
                return atomDefinition1.proposedCounterpart == atomDefinition2 && atomDefinition2.proposedCounterpart == atomDefinition1;
            }
            if (atomDefinition1.atom == atomDefinition2.atom && IdenticalBonds(atomDefinition1, atomDefinition2))
            {
                atomDefinition1.proposedCounterpart = atomDefinition2;
                atomDefinition2.proposedCounterpart = atomDefinition1;
                bool flag1 = true;
                foreach (BondDefinition bond in atomDefinition1.bonds)
                {
                    AtomDefinition subAtom1 = (bond.atom1 == atomDefinition1 ? bond.atom2 : bond.atom1);
                    bool flag2 = false;
                    foreach (AtomDefinition subAtom2 in atomDefinition2.GetBondedAtoms(bond.bondCount))
                    {
                        if (MoleculeMatchesRecursive(subAtom1, subAtom2))
                        {
                            flag2 = true;
                            break;
                        }
                    }
                    if (!flag2) // Found no match for subAtomDefinition1, molecule mismatch
                    {
                        flag1 = false;
                        break; // Return false through the recursion
                    }
                }
                if (flag1)
                    return true;
            }
            // Clean up the proposed counterparts on failure, and *only* on failure.
            // On success, we commit to the counterparts so other parts of the molecules can't be paired with them.
            atomDefinition1.proposedCounterpart = null;
            atomDefinition2.proposedCounterpart = null;
            return false;
        }
    }
}