using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qXPDgDKkaLHv8dUsdBju7I9tSWtak8UKiL0LSEyQcDcc=")]
    public struct Vector2f
    {
        [Decoy("op_Implicit")]
        public static implicit operator Vector2i(Vector2f vector)
        {
            return new Vector2i();
        }

        [Decoy("#=qPgVG4DQDLqHkFK3fjgqojw==")]
        public float Length()
        {
            return 0;
        }

        [Decoy("op_Division")]
        public static Vector2f operator /(Vector2f left, float right)
        {
            return new Vector2f();
        }

        [Decoy("op_Multiply")]
        public static Vector2f operator *(Vector2f left, float right)
        {
            return new Vector2f();
        }
    }
}
