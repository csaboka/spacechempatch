using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qbDHq1QnTdnbI0$5SkMcc5oEC$df9drSchVoPijROKY$5GhnEBHYc6mlU4nn1pbus")]
    class MoleculeBuilderWithRatios
    {
        [Replaced(".ctor", Patch.AllowGreekInResNet, Patch.AllowGreekInResNetProdAndSandbox, KeepOriginal = true)]
        public MoleculeBuilderWithRatios(ResearchNetResearchPuzzleDefinition.Inputs inputs, Action<ResearchNetResearchPuzzleDefinition.Inputs> action, bool showGreek = false)
            : this(inputs, action, true, Original.INSTANCE)
        {

        }

        public MoleculeBuilderWithRatios(ResearchNetResearchPuzzleDefinition.Inputs inputs, Action<ResearchNetResearchPuzzleDefinition.Inputs> action, bool showGreek, Original dummy)
        {

        }
    }
}
