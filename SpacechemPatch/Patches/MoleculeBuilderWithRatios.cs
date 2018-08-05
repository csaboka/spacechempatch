using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qbDHq1QnTdnbI0$5SkMcc5oEC$df9drSchVoPijROKY$5GhnEBHYc6mlU4nn1pbus")]
    class MoleculeBuilderWithRatios
    {
        [Replaced(".ctor", Patch.AllowGreekInResearchNet, KeepOriginal = true)]
        public MoleculeBuilderWithRatios(ResearchNetResearchPuzzleDefinition.UnknownClass1 unk1, Action<ResearchNetResearchPuzzleDefinition.UnknownClass2> action, bool showGreek = false)
            : this(unk1, action, true, Original.INSTANCE)
        {

        }

        public MoleculeBuilderWithRatios(ResearchNetResearchPuzzleDefinition.UnknownClass1 unk1, Action<ResearchNetResearchPuzzleDefinition.UnknownClass2> action, bool showGreek, Original dummy)
        {

        }
    }
}
