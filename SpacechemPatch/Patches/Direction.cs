using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qdkrhYwTvlVKUT3KMWoVTm1CHNWhszSBqjJOltUAwOa9DOilLN68Nd$S3dSdgSV2w")]
    internal enum Direction
    {
        Up = -90, // -0x0000005A
        None = -1,
        Right = 0,
        Down = 90, // 0x0000005A
        Left = 180, // 0x000000B4
    }

}
