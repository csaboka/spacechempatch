using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qZmVouIwdOUk3rgavS2kQXg==")]
    struct Atom
    {
        [Decoy("#=qcegoc0tPzOg3I6MLjL1oUg==")]
        public Element element;

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

        [Decoy("#=qP$zaMfup7hWMBSbziLr1pHL_JT_q4fwUf$A2mDYcU6E=")]
        public int GetMaxBonds()
        {
            return 0;
        }
    }
}
