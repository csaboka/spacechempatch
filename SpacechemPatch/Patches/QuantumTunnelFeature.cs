using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qdKGLnt2KfTK9zD4G7oVABoHPmqWKuNs4WSYAqh1HVZ3susdV5V8wUWO$qRFxovFL")]
    internal sealed class QuantumTunnelFeature : AbstractFeature
    {
        [Decoy(".ctor")]
        public QuantumTunnelFeature(Reactor reactor) :
            base(null, null, false, null, default(Vector2i))    // This is not the real super call, just here to make the compiler happy.
        {

        }

    }
}
