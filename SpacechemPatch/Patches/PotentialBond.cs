using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qWgrbwqbvXvEqIZMyqWhn55SeNhulH_VkhJsCuQxkpAA=")]
    struct PotentialBond
    {
        [Decoy("#=qv0QYiQzIAjSEoH_waza2ZQ==")]
        public Vector2i coords;

        [Decoy("#=qFphH1$6KeFVyx5KxARmVtcdFkuQxoy1TNfbODoLu1vo=")]
        public Vector2i getCoordsOfOtherBonder()
        {
            return new Vector2i();
        }
    }
}
