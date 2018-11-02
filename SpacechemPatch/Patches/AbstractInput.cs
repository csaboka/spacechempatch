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
        [Decoy("#=qvRIcsfXje1I6O$_kVhlsUw==")]
        private List<MoleculeDefinition> inputMolecules;
        [Decoy("#=qz5YVBocJAqdYoXw5r_8DFOrEaZFouqAkdNe9K1JMTzQ=")]
        private List<int> inputFrequencies;
        [Decoy("#=qOtJVuETuW_qVboE2q441rQ==")]
        private Queue<MoleculeDefinition> pendingMolecules;
        [Decoy("#=qse7XwupTBPPdxuy1VBotVQ==")]
        private int randomSeed;

        // Fields necessary for the reimplemented random generation
        [Injected]
        private int inext;
        [Injected]
        private int inextp;
        [Injected]
        private int[] SeedArray;
        [Injected]
        private bool SkipRandomForTrivialRanges;

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
            InitRandom(31);
            SkipRandomForTrivialRanges = true;
        }

        [Replaced("#=qQ35xZz04iKhiXjOwE7un_g==", Patch.ForceWindowsMoleculeOrder, KeepOriginal = true, NewNameForOriginal = "OriginalReset")]
        public void ResetWindows()
        {
            OriginalReset();
            InitRandom(21);
        }

        private void OriginalReset()
        {

        }

        [Replaced("#=qeQ6qZnDUluxf3jmyqIM79Q==", Patch.ForceLinuxMoleculeOrder, Patch.ForceWindowsMoleculeOrder)]
        private void ResetPending()
        {
            pendingMolecules.Clear();
            // Put each molecule in a bag with the assigned frequency, then pull
            // random molecules from the bag until it's empty.
            List<MoleculeDefinition> bag = new List<MoleculeDefinition>();
            for (int moleculeIndex = 0; moleculeIndex < inputMolecules.Count; ++moleculeIndex)
            {
                for (int i = 0; i < inputFrequencies[moleculeIndex]; ++i)
                {
                    bag.Add(inputMolecules[moleculeIndex]);
                }
            }
            while (bag.Count > 0)
            {
                int index = RandomBelow(bag.Count);
                pendingMolecules.Enqueue(bag[index]);
                bag.RemoveAt(index);
            }
        }

        [Injected]
        private void InitRandom(int initialInextp)
        {
            // The following is a copy of the Random constructor from the .NET Reference Source,
            // with small tweaks to make patching easier and allow substituting the old Mono behavior.
            int ii;
            int mj, mk;

            //Initialize our Seed array.
            //This algorithm comes from Numerical Recipes in C (2nd Ed.)
            int subtraction = (randomSeed == Int32.MinValue) ? Int32.MaxValue : Math.Abs(randomSeed);
            mj = 161803398 - subtraction;
            SeedArray = new int[56];
            SeedArray[55] = mj;
            mk = 1;
            for (int i = 1; i < 55; i++)
            {  //Apparently the range [1..55] is special (Knuth) and so we're wasting the 0'th position.
                ii = (21 * i) % 55;
                SeedArray[ii] = mk;
                mk = mj - mk;
                if (mk < 0) mk += Int32.MaxValue;
                mj = SeedArray[ii];
            }
            for (int k = 1; k < 5; k++)
            {
                for (int i = 1; i < 56; i++)
                {
                    SeedArray[i] -= SeedArray[1 + (i + 30) % 55];
                    if (SeedArray[i] < 0) SeedArray[i] += Int32.MaxValue;
                }
            }
            inext = 0;
            // The only significant difference between the Microsoft algorithm and the old Mono algorithm
            // seems to be the initial value of the inextp field, so make this configurable.
            inextp = initialInextp;
        }

        [Injected]
        private int RandomBelow(int max)
        {
            // The old Mono code doesn't update the generator state when only one return value is valid.
            // We need to mimic this behavior to faithfully reproduce the Linux randomness.
            if (max <= 1 && SkipRandomForTrivialRanges)
            {
                return 0;
            }
            // This is also coming from the .NET Reference Source, merging the logic of Next() and InternalSample().
            int retVal;

            if (++inext >= 56) inext = 1;
            if (++inextp >= 56) inextp = 1;

            retVal = SeedArray[inext] - SeedArray[inextp];

            // The following line isn't present in the old Mono sources, but without it, it's possible to return the maximum value and violate the contract.
            if (retVal == Int32.MaxValue) retVal--;
            if (retVal < 0) retVal += Int32.MaxValue;

            SeedArray[inext] = retVal;

            return (int)(retVal*(1.0/Int32.MaxValue)*max);
        }
    }
}
