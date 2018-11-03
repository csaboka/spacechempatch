using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qgb_1dBoxJTxMr57bMeIXeThMSy7VcbiYQtte9Drmlz4=")]
    struct BoundingBox
    {
        [Decoy(".ctor")]
        public BoundingBox(Vector2i topLeft, Vector2i dimensions)
        {
        }

        [Decoy(".ctor")]
        public BoundingBox(int x, int y, int width, int height)
        {
        }

        [Decoy("#=qzZCFhMSRiU$M7Tzmtv$20w==")]
        public Vector2i GetCenter()
        {
            return new Vector2i();
        }
    }
}
