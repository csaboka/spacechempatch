using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=q50Yq9Me1s2AJ5uIhhU6V4lraWdgGLyXTw28eWbPrhLcMyyxIinZa6Urcp2WHCq$Z")]
    class ResearchNetResearchPuzzleDefinition : ResearchNetPuzzleDefinition
    {
        [Decoy("#=q39ulrHCaIbRwWgaeMcWXyQ==")]
        public sealed class Inputs
        {
            [Decoy("#=qUCdShVP5cRtybGImHpYbVA==")]
            public List<MoleculeAndCount> molecules;
        }
    }
}
