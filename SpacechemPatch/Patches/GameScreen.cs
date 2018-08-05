using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qZeYXrtOJ5j$IGcYQXGvBcQltydfgyRcQ4ciBoCJGRj0=")]
    class GameScreen
    {
        [Decoy("#=qY_VJ0NICSBZ0Kwnw4R7HGw==")]
        public static T GetTopmostScreenWithType<T>() where T : GameScreen
        {
            return null;
        }
    }
}
