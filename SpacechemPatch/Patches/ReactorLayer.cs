using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qh2pSYbUJLebVWoIXIt7zQSEPMTK12GgkFAme864uKfs=")]
    internal enum ReactorLayer
    {
        None = 0,
        Background = 1,
        Molecules = 2,
        BetaLines = 4,
        AlphaLines = 8,
        BetaArrow = 16, // 0x00000010
        Beta = 32, // 0x00000020
        AlphaArrow = 64, // 0x00000040
        Alpha = 128, // 0x00000080
        TopEffects = 256, // 0x00000100
        AllBeta = Beta | BetaArrow | BetaLines, // 0x00000034
        AllAlpha = Alpha | AlphaArrow | AlphaLines, // 0x000000C8
        All = 4095, // 0x00000FFF
    }
}
