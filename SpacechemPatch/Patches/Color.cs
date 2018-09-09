using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qRBdw085jF4c5V3uyKl5XSg==")]
    struct Color
    {
        [Decoy("#=q_Sl03R0Lza439t5m0v9OFQ==")]
        public static readonly Color WHITE;

        [Decoy("op_Multiply")]
        public static Color operator *(Color left, Color right)
        {
            return new Color();
        }

        [Decoy("#=qGxeAC5yjWe0Fo556pvb$WQ==")]
        public Color WithAlpha(float alpha)
        {
            return new Color();
        }
    }
}
