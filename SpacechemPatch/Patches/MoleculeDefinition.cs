using System;
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
            // Pre-allocating the undo stack is just an optimization. Every time MoleculeMatchesRecursive()
            // returns false, it restores the stack to its initial state, so it's safe to reuse
            // the same object instead of allocating new ones for each call. We quit when
            // MoleculeMatchesRecursive() returns true, so we don't care about whatever is left there in that case.
            List<AtomDefinition> undoStack = new List<AtomDefinition>(atoms.Count * 2);
            foreach (AtomDefinition atomDefinition1 in dictionary1.Values)
            {
                foreach (AtomDefinition atomDefinition2 in dictionary2.Values)
                {
                    if (MoleculeMatchesRecursive(atomDefinition1, atomDefinition2, undoStack))
                        return true;
                }
            }
            return false;
        }

        [Injected]
        private static bool MoleculeMatchesRecursive(AtomDefinition atomDefinition1, AtomDefinition atomDefinition2, List<AtomDefinition> undoStack)
        {
            // Make sure we don't match an atom that's already matched with something else. This check also prevents infinite
            // recursion when an atom is revisited by one of its neighbors.
            if (atomDefinition1.proposedCounterpart != null || atomDefinition2.proposedCounterpart != null)
            {
                return atomDefinition1.proposedCounterpart == atomDefinition2 && atomDefinition2.proposedCounterpart == atomDefinition1;
            }
            if (atomDefinition1.atom == atomDefinition2.atom && IdenticalBonds(atomDefinition1, atomDefinition2))
            {
                int undoStackTop = undoStack.Count;
                // undoStack contains all atoms that have a proposed counterpart. It's used to clean up counterparts if a full match cannot be made.
                // Indexes smaller than undoStackTop represent assumptions made by callers in higher levels. At this level, we treat them as
                // absolute fact. Indexes larger or equal to undoStackTop represent assumptions made in this call, or lower callers. We must undo
                // these assumptions if we can't make a full match.
                atomDefinition1.proposedCounterpart = atomDefinition2;
                atomDefinition2.proposedCounterpart = atomDefinition1;
                undoStack.Add(atomDefinition1);
                undoStack.Add(atomDefinition2);
                bool flag1 = true;
                foreach (BondDefinition bond in atomDefinition1.bonds)
                {
                    AtomDefinition subAtom1 = (bond.atom1 == atomDefinition1 ? bond.atom2 : bond.atom1);
                    bool flag2 = false;
                    foreach (AtomDefinition subAtom2 in atomDefinition2.GetBondedAtoms(bond.bondCount))
                    {
                        if (MoleculeMatchesRecursive(subAtom1, subAtom2, undoStack))
                        {
                            flag2 = true;
                            break;
                        }
                        // It's an invariant that whenever MoleculeMatchesRecursive retuns false, it restores undoStack
                        // to the state it was on method entry, so no need to touch undoStack here.
                    }
                    if (!flag2) // Found no match for subAtomDefinition1, molecule mismatch
                    {
                        flag1 = false;
                        break; // Return false through the recursion
                    }
                }
                if (flag1)
                    return true;
                // clean up the assumptions
                while (undoStack.Count > undoStackTop)
                {
                    undoStack[undoStack.Count - 1].proposedCounterpart = null;
                    undoStack.RemoveAt(undoStack.Count - 1);
                }
            }
            return false;
        }

        [Decoy("#=qsoCro4fIXL_XiE72I3Qawg==")]
        public void Translate(Vector2i translation)
        {

        }

        [Decoy("#=qUcmoUVau7Ojk9o6cxOlrfw==")]
        public void CopyAtomsAndBonds(MoleculeDefinition source)
        {

        }

        [Decoy("#=qEOwPCzqdYEPHZzccOMAjsQ==")]
        public BondCount? GetBondCount(PotentialBond potentialBond)
        {
            return null;
        }

        [Decoy("#=qqX78R1WZtC9w50e$D7ubig==")]
        public bool SetBondCountWithMaxBondsCheck(PotentialBond potentialBond, BondCount bondCount)
        {
            return false;
        }

        [Decoy("#=qh7iU6l7yfahEIFu0I6WHVA==")]
        public static IEnumerable<MoleculeDefinition> BreakBond(MoleculeDefinition moleculeDefinition, PotentialBond bondToRemove)
        {
            return null;
        }

        [Decoy("#=qCaZyX4916r1WTQ4t11XP8w==")]
        public void SetBondCount(PotentialBond potentialBond, BondCount? bondCount)
        {

        }

        [Replaced("#=qEWMFMGYt$ds9yZCF1hDd_Q==", Patch.AllowBondsForUnknownInNotes)]
        public bool AddAtomOrBond(DraggedAtomOrBondInfo atomOrBond, int x, int y)
        {
            Vector2i position = new Vector2i(x, y);
            if (atomOrBond.mode == AtomOrBondDragMode.AtomDrag)
            {
                ReplaceAtomWithBondCountEnforcement(position, atomOrBond.atom);
                return true;
            }
            if (atomOrBond.mode == AtomOrBondDragMode.BondOverride)
                // This is the only line we've changed. This method can only be called from the molecule editor UI,
                // and since the unknown element is only shown for output note editors, we can safely define special
                // rules for it without breaking gameplay. If someone already hacked an unknown element into a custom
                // puzzle input or output, they can also hack invalid bonds, so we aren't opening new exploits, either.
                return SetBondCountWithSpecialUnknownHandling(new PotentialBond(position, atomOrBond.bondDirection), atomOrBond.bondCount);
            if (atomOrBond.mode == AtomOrBondDragMode.BondRemoval)
                return RemoveBond(new PotentialBond(position, atomOrBond.bondDirection));
            return false;
        }

        [Decoy("#=qQH0U9w$CRrIgsuNXzn1TSA==")]
        private void ReplaceAtomWithBondCountEnforcement(Vector2i position, Atom atom)
        {
        }

        [Decoy("#=q2UHh48ywQ2poY0A8Bxu6Ug==")]
        public bool RemoveBond(PotentialBond potentialBond)
        {
            return false;
        }

        [Injected]
        public bool SetBondCountWithSpecialUnknownHandling(PotentialBond potentialBond, BondCount bondCount)
        {
            if (!atoms.ContainsKey(potentialBond.coords) || !atoms.ContainsKey(potentialBond.getCoordsOfOtherBonder()))
            {
                return false;
            }
            if (bondCount > (BondCount)GetBondCountAsInt(potentialBond))
            {
                Atom sourceAtom = atoms[potentialBond.coords];
                if (sourceAtom.element != Element.Unknown &&
                    (GetTotalBondsAt(potentialBond.coords) - GetBondCountAsInt(potentialBond) + bondCount > (BondCount)sourceAtom.GetMaxBonds()))
                {
                    // source atom would be over max. bonds
                    return false;
                }
                Atom targetAtom = atoms[potentialBond.getCoordsOfOtherBonder()];
                if (targetAtom.element != Element.Unknown &&
                    (GetTotalBondsAt(potentialBond.getCoordsOfOtherBonder()) - GetBondCountAsInt(potentialBond) + bondCount > (BondCount)targetAtom.GetMaxBonds()))
                {
                    // target atom would be over max. bonds
                    return false;
                }
            }
            SetBondCount(potentialBond, new BondCount?(bondCount));
            return true;
        }

        [Decoy("#=qs43NDZaM71S7Vvv2bGsbxFVtigjocHzMX0hvFioIORY=")]
        private int GetBondCountAsInt(PotentialBond bond)
        {
            return 0;
        }

        [Decoy("#=qhm_cjQgiQdt8lty_PSYJd_vHIOsKU2AapEGcQrL9vOE=")]
        private int GetTotalBondsAt(Vector2i position)
        {
            return 0;
        }
    }
}
