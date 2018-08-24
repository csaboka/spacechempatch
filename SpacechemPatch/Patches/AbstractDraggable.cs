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
        private int priority;

        [Decoy("#=q_rKTlntlJmkIAnzj3v8jwWocRPnTP6SCM$DxwK7qjyw=")]
        public virtual void MakeTooltip()
        {

        }

        [Replaced("#=qtrBzOdYZZ65GB65VDAbBsQ==", Patch.ShowReactorPriority, KeepOriginal = true, NewNameForOriginal = "OriginalRender")]
        public virtual void Render(SpriteBatch spriteBatch, Color color, Vector2i position)
        {
            if (inputPipes.Count > 0 || outputPipes.Count > 0)
            {
                int newPriority = 1;
                bool found = false;
                foreach (KeyValuePair<AbstractDraggable, Vector2i> pair in ownerContainer)
                {
                    AbstractDraggable draggable = pair.Key;
                    if (draggable == this)
                    {
                        found = true;
                        break;
                    }
                    else if (draggable.inputPipes.Count > 0 || draggable.outputPipes.Count > 0)
                    {
                        newPriority++;
                    }
                }
                if (found && newPriority != priority)
                {
                    // Building a tooltip is expensive, so only rebuild it if the priority changes.
                    priority = newPriority;
                    string nameBackup = name;
                    name = String.Format("{0} ({1})", name, newPriority);
                    MakeTooltip();
                    name = nameBackup;
                }
            }
            OriginalRender(spriteBatch, color, position);
        }

        public virtual void OriginalRender(SpriteBatch spriteBatch, Color color, Vector2i position)
        {

        }
    }
}
