using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qeMkxR7vaaTlQEKn3e3$h8aYHI9cwaFN$5ZslOd5Rsf0=")]
    abstract class AbstractDraggable
    {
        [Decoy("#=qwU8KHRzlGPCy0f_JazUY6g==")]
        public string name;
        [Decoy("#=q2EFFSSATZEqIYslIzTR92Q==")]
        protected DraggableContainer ownerContainer;
        [Decoy("#=qNsKHf_LaRXE21IlmwRCRKg==")]
        public PipeList<InputPipe> inputPipes;
        [Decoy("#=q8SkGy0Us0c0Tm2sfolvmMw==")]
        public PipeList<OutputPipe> outputPipes;
        [Injected]
        internal int priority;

        [Decoy("#=q_rKTlntlJmkIAnzj3v8jwWocRPnTP6SCM$DxwK7qjyw=")]
        public virtual void MakeTooltip()
        {

        }

        [Decoy("#=qtrBzOdYZZ65GB65VDAbBsQ==")]
        public virtual void Render(SpriteBatch spriteBatch, Color color, Vector2i position)
        {
        }
    }
}
