using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qRBdw085jF4c5V3uyKl5XSg==")]
    struct Color
    {
        [Decoy("op_Multiply")]
        public static Color operator *(Color left, Color right)
        {
            return new Color();
        }
    }
}
