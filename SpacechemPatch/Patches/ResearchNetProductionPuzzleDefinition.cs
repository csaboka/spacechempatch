using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qa3pVnoisAUqS$$CZkFaxsOPdiHpkdnVyWKNr$QRQ5emnVdJscF7kUHuA3Fj1f4aJ")]
    class ResearchNetProductionPuzzleDefinition : ResearchNetPuzzleDefinition
    {
        [Decoy("#=quAUiCG0iVpegt_Nx53a9nQ==")]
        public static readonly List<Terrain> terrains;

        public override bool IsIncompatibleWith(ResearchNetPuzzleDefinition definition)
        {
            // This method isn't used by the patcher, it's just here to make the compiler happy.
            return false;
        }

        public override void Init()
        {
            // This method isn't used by the patcher, it's just here to make the compiler happy.
        }

        [Decoy("#=q27GLFggBQpBRmxqpzGoSmYHSren0WfM$WTa8xWwai0A=")]
        public Dictionary<int, ResearchNetResearchPuzzleDefinition.Inputs> randomInputZones;
        [Decoy("#=qRfAz7EkMvr7GSaljUFjNku45U5grS57mK199HJRl0JA=")]
        public Dictionary<int, MoleculeDefinition> fixedInputZones;
        [Decoy("#=qecPW3VDB23YVsFijydPHHQ==")]
        public Dictionary<int, MoleculeAndCount> outputZones;
        [Decoy("#=q_Uza9uAcDDyCQR0vLka_2w==")]
        public int terrain;
        [Decoy("#=qJic0XVa4VnKvlVMQ1ZfJYQ==")]
        public int maxReactors;
        [Decoy("#=qf1EVk8FPQ1S5V5XqN2jugQ==")]
        public bool hasRecycler;

        [Decoy("#=qcez_CIq$Prece1IYRgBagPjNWdrOELrSqsoimig2tUw=")]
        public sealed class Terrain
        {
            [Decoy("#=qgysE6vodnj7hpzFuEko2xA==")]
            public TextureElement terrainTexture;
            [Decoy("#=qS2uRQ3eDTBeCqRIF$bCBnA==")]
            public int verticalOffset;
            [Decoy("#=qxPQJoY3zhNrNY_lkkY0S2A==")]
            public HashSet<Vector2i> occupiedSquares;
            [Decoy("#=qZoO32R4GQH6mn0K0mXX1sA==")]
            public bool gridLinesLessVisible;
            [Decoy("#=qWHIMSNSJLzP_V6urK1FZFA==")]
            public bool isMining;
        }
    }
}
