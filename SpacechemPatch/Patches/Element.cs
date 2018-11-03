using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [SpacechemPatch.Decoy("Element", @namespace = "SpaceChem")]
    enum Element
    {
        Unknown = 0
        // Add elements as needed. There's no point in replicating the whole periodic table here.
    }
}
