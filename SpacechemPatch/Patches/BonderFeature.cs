using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qxxRrE0U2EIfozdVZOaULNbKFnOET_UqJAsKEIpyyF8I=")]
    class BonderFeature : AbstractFeature
    {
        [Decoy("#=qPCIcCqoV2w6ex6WB5x0aPiWYYMGNwrEnjNVAAQVQr3d8QjpL9b4nuVCpsYKusRWK")]
        private static Func<ReactorMember, bool> isBonderFeatureCache;

        [Decoy(".ctor")]
        public BonderFeature(Reactor reactor)
            : base(reactor, null, false, null, new Vector2i())  // This is just to make the compiler happy, it's _not_ the real base constructor call!
        {

        }

        [Replaced("#=qWQJ$dMDcjxjokRp8n71Fzg==", Patch.ShowBonderPriority, KeepOriginal = true, NewNameForOriginal = "OriginalRender")]
        public override void Render(SpriteBatch spriteBatch, Vector2i position, ReactorLayer layer, Color color, float zOrder, ImageSize imageSize, bool forDragAndDrop)
        {
            OriginalRender(spriteBatch, position, layer, color, zOrder, imageSize, forDragAndDrop);
            if (ownerReactor != null && !forDragAndDrop && imageSize == ImageSize.Normal)
            {
                int priority = 1;
                foreach (ReactorMember member in ownerReactor.GetMembers())
                {
                    if (member == this)
                    {
                        break;
                    }
                    else if (member is BonderFeature)
                    {
                        priority++;
                    }
                }
                RenderPriority(spriteBatch, position, color, zOrder, priority);
            }
        }

        public void OriginalRender(SpriteBatch spriteBatch, Vector2i position, ReactorLayer layer, Color color, float zOrder, ImageSize imageSize, bool forDragAndDrop)
        {

        }

        [Replaced("#=q1yXTWEvMDMnFbCwhCbQ6GQ==", Patch.FixTelekinesis)]
        public static void DoBond(BondType bondType, Reactor reactor, bool forRed)
        {
            foreach (PotentialBond potentialBond in GetPotentialBonds(reactor, bondType))
            {
                Molecule molecule1 = reactor.moleculeList.getMoleculeAtCoords(potentialBond.coords);
                Molecule molecule2 = reactor.moleculeList.getMoleculeAtCoords(potentialBond.getCoordsOfOtherBonder());
                if (molecule1 != null && molecule2 != null)
                {
                    MoleculeDefinition resultMolecule = molecule1.GetTransformedDefinition(Vector2i.NULL);
                    if (bondType == BondType.Plus)
                    {
                        if (molecule1 != molecule2)
                            resultMolecule.CopyAtomsAndBonds(molecule2.GetTransformedDefinition(Vector2i.NULL));
                        BondCount numBonds = (BondCount)1;
                        // Math.Min(atom.bondCount(potentialBond).Value + 1, 3)
                        // aka increase bonds by 1 but not more than 3
                        if (resultMolecule.GetBondCount(potentialBond).HasValue)
                            numBonds = (BondCount)Math.Min((int)(resultMolecule.GetBondCount(potentialBond).Value + 1), 3);
                        if (resultMolecule.SetBondCountWithMaxBondsCheck(potentialBond, numBonds))
                        {
                            reactor.moleculeList.Remove(molecule1);
                            if (molecule1 != molecule2)
                                reactor.moleculeList.Remove(molecule2);
                            reactor.moleculeList.Add(new Molecule(resultMolecule, reactor));
                            reactor.AddBondEffect((potentialBond.coords + potentialBond.getCoordsOfOtherBonder()) * 0.5f, BondEffectStyle.Plus, forRed);
                        }
                        else
                        {
                            reactor.AddBondEffect((potentialBond.coords + potentialBond.getCoordsOfOtherBonder()) * 0.5f, BondEffectStyle.MaxBonds, forRed);
                            // The next line is the only change in this method, and should fix the telekinesis bug.
                            // If both waldos hold the same molecule and we allow execution to continue to the next foreach,
                            // the following would happen:
                            // 1. The pull vectors of the molecule are cleared.
                            // 2. The red waldo adds itself to the molecule's pull vectors in GrabDrop().
                            // 3. The pull vectors of the molecule are cleared _again_, removing the red waldo.
                            // 4. The blue waldo adds itself to the molecule's pull vectors in GrabDrop().
                            // The end result is that the game thinks only blue is holding the molecule, triggering the telekinesis bug.
                            // It's safe to skip this foreach since hitting max bonds means no molecule was changed and the current pull vectors are still OK.
                            continue;
                        }
                    }
                    // bondType != BondType.Plus
                    else if (molecule1 == molecule2 && resultMolecule.GetBondCount(potentialBond).HasValue)
                    {
                        reactor.moleculeList.Remove(molecule1);
                        int newBondCount = (int)(resultMolecule.GetBondCount(potentialBond).Value - 1);
                        if (newBondCount < 1)
                        {
                            foreach (MoleculeDefinition newMolecule in MoleculeDefinition.BreakBond(resultMolecule, potentialBond))
                                reactor.moleculeList.Add(new Molecule(newMolecule, reactor));
                        }
                        else
                        {
                            resultMolecule.SetBondCount(potentialBond, new BondCount?((BondCount)newBondCount));
                            reactor.moleculeList.Add(new Molecule(resultMolecule, reactor));
                        }
                        reactor.AddBondEffect((potentialBond.coords + potentialBond.getCoordsOfOtherBonder()) * 0.5f, BondEffectStyle.Minus, forRed);
                    }
                    else
                        continue;
                    foreach (Waldo waldo in reactor.waldos.Values)
                    {
                        if (waldo.molecule != null)
                        {
                            waldo.molecule.WaldoPullVectors.Clear();
                            waldo.molecule = null;
                            waldo.GrabDrop();
                        }
                    }
                }
            }
            if (isBonderFeatureCache == null)
                isBonderFeatureCache = new Func<ReactorMember, bool>(IsBonderFeature);
            foreach (BonderFeature bonderFeature in reactor.GetMembers().Where(isBonderFeatureCache).Cast<BonderFeature>())
                bonderFeature.Activate(forRed);
        }

        [Decoy("#=qHao93d4t2hZ2OPUC_mQ53w==")]
        public static LinkedList<PotentialBond> GetPotentialBonds(Reactor reactor, BondType bondType)
        {
            return null;
        }

        [Decoy("#=qxcDCHDfzRNqAM6XohCf1zA==")]
        private static bool IsBonderFeature(ReactorMember member)
        {
            return false;
        }

    }
}
