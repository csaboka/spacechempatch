using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("Vector2i", @namespace = "Impeller")]
    struct Vector2i
    {
        [Decoy("#=qQeZspJ4Xad5R9_RFi53Asw==")]
        public int x;
        [Decoy("#=qPkNd7qcHpcMBBXqDfc5GPQ==")]
        public int y;

        [Decoy(".ctor")]
        public Vector2i(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
