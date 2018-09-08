using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qtl2wJnXgM0Mq3un0pcVWel4o1GcuH8cP$M_0vYWJiS0=")]
    class Reactor
    {
        [Decoy(".ctor")]
        public Reactor(ReactorScreen reactorScreen, Vector2i position, Vector2i dimensions, ReactorLayout genum2_1, bool bool_2 = false)
        {

        }

        [Decoy("#=qZ3mqnGc9DDHuYhhM_UXxgQ==")]
        public IEnumerable<ReactorMember> GetMembers()
        {
            return null;
        }

        [Decoy("#=qxU2FtX7PCPSqVgohhP$fIA==")]
        public void AddMember(Vector2i coords, ReactorLayer layer, ReactorMember member)
        {

        }
    }
}
