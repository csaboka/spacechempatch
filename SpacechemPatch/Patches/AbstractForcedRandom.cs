using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    // Re-implement just enough functionality of Random to allow forcing Windows behavior vs. old Mono behavior
    [Injected(Patches = new Patch[] { Patch.ForceLinuxMoleculeOrder, Patch.ForceWindowsMoleculeOrder})]
    class AbstractForcedRandom : Random
    {
        private int inext;
        private int inextp;
        private int[] SeedArray;

        protected AbstractForcedRandom(int randomSeed, int initialInextp)
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

        // The proper way of implementing a custom Random implementation is to override Sample(), but
        // the game will always call just this overload, so we'll cut some corners and override only this.
        public override int Next(int minValue, int maxValue)
        {
            // We're ignoring minValue since the game will always pass 0. Remember not to do this with code that's actually going to be reused, dear reader!

            // This is also coming from the .NET Reference Source, merging the logic of Next() and InternalSample().
            int retVal;

            if (++inext >= 56) inext = 1;
            if (++inextp >= 56) inextp = 1;

            retVal = SeedArray[inext] - SeedArray[inextp];

            // The following line isn't present in the old Mono sources, but without it, it's possible to return the maximum value and violate the contract.
            if (retVal == Int32.MaxValue) retVal--;
            if (retVal < 0) retVal += Int32.MaxValue;

            SeedArray[inext] = retVal;

            return (int)(retVal * (1.0 / Int32.MaxValue) * maxValue);
        }
    }
}
