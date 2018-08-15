using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qZBoyrzQj20R8rdULQBRXM7qExfsLwLcsPh3gIbcTweY=")]
    class AbstractPuzzle : GameScreen
    {
        [Decoy("#=q_CyJMt57u4kvOhJiMRQahQ==")]
        public DraggableContainer draggableContainer;
        [Decoy("#=qUD7nJ2IzPuFxt1lQCojlau6Yg$y12maiQ$umgpfT7J8=")]
        public int maxReactors;

        [Decoy(".ctor")]
        public AbstractPuzzle(bool flipFlopsAvailable)
        {
        }
    }
}
