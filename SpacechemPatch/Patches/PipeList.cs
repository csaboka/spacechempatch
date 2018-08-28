using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qd$NHgyE25bphJ9$pmpAnjfF11zg$usxAgkO4r2nIeqTi0z_m2POTj$ZG8xGRngjk")]
    sealed class PipeList<T> : SortedList<int, T> where T : AbstractPipe
    {
    }
}
