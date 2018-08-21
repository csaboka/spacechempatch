using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch
{
    enum Patch
    {
        AllowGreekInResNet,
        AllowGreekInResNetProdAndSandbox,
        FixWrongOutput,
        ResNetProdCustomAmount,
        ReverseOrderCustomResNetAssignments,
        ShowBonderPriority,
        ShowOver100kCycles
    }
}
