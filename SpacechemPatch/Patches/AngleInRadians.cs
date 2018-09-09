using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=q_jRFx7VyYFz9R6cW_6g5y2SXU7aVBG$2lPsdoP91hc0=")]
    struct AngleInRadians
    {
        [Decoy("op_Implicit")]
        public static implicit operator AngleInRadians(float angle)
        {
            return new AngleInRadians();
        }
    }
}
