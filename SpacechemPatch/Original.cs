using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch
{
    // The purpose of this class is just to have a type that's guaranteed not to
    // already exist in SpaceChem code. When we want to keep the original code
    // we're replacing, we can always introduce a new overload by just adding
    // this type to the end of the parameter list. This way, we can retain things
    // that cannot be renamed, such as constructors, by just introducing an overload.
    public class Original
    {
        public static readonly Original INSTANCE;
        private Original()
        {

        }
    }
}
