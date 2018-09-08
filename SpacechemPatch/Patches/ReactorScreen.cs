using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qb8BMTaR4woBSvwUJyoGSZOANknfvOq16gLVzyJYyUkKaWdxd4iUViblWKZpMaqTg")]
    internal class ReactorScreen : GameScreen
    {
        [Decoy("#=qP_zbfiISOnt8SIHSa5SQyg==")]
        public Reactor reactor;
        [Decoy("#=qvxM9iDES5baUB_oIGLNflQ==")]
        public InstructionsPanel instructionsPanel;
        [Decoy("#=qcP5VH5B2Hp3JLQ3d7aJr7g==")]
        public ReactorSimulationEngine simulationEngine;

        [Decoy(".ctor")]
        public ReactorScreen(AbstractReactorType reactoryType)
        {

        }
    }
}
