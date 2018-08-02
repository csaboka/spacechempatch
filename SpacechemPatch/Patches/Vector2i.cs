using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("Vector2i", @namespace="Impeller")]
    struct Vector2i
    {
        [Decoy(".ctor")]
        public Vector2i(int x, int y)
        {

        }
    }
}
