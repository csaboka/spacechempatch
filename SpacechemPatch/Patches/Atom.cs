using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qZmVouIwdOUk3rgavS2kQXg==")]
    struct Atom
    {
        [Decoy("op_Equality")]
        public static bool operator == (Atom atom1, Atom atom2)
        {
            return false;
        }

        [Decoy("op_Inequality")]
        public static bool operator != (Atom atom1, Atom atom2)
        {
            return false;
        }
    }
}
