using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qQ6CyedymXCIh4eawekuhYeGzoc$3z4fjcH2LHbSxCIVndIEFY8DUMjKBTqqYUrlb")]
    class Puzzle_ResNetResearch : ResearchPuzzle
    {
        [Decoy(".ctor")]
        public Puzzle_ResNetResearch()
            : base(typeof(ReactorResearchCustom), true)
        {
        }
    }
}
