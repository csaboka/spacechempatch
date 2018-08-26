using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qXybtTWc6YL3Bmjhy$yqnlfUddKSeC7LYrXOWWRjn3Mw=")]
    class DraggableContainer : IEnumerable, IEnumerable<KeyValuePair<AbstractDraggable, Vector2i>>
    {
        [Decoy("#=qDQbKsgZeTgbZH6Pf_xOGPA==")]
        protected Dictionary<AbstractDraggable, Vector2i> draggableToPositionMapping = new Dictionary<AbstractDraggable, Vector2i>();

        [Decoy("#=qllJBIbK0DPLdvHTYBwLeTg==")]
        public void PutDraggableAtCoords(int x, int y, AbstractDraggable draggable)
        {
        }

        [Replaced("#=qQsBO26A2HaS0lBEN6y0MSA==", Patch.ShowReactorPriority, KeepOriginal = true, NewNameForOriginal = "OriginalRenderProduction")]
        public void RenderProduction(SpriteBatch spriteBatch)
        {
            int newPriority = 0;
            foreach (AbstractDraggable draggable in draggableToPositionMapping.Keys)
            {
                if (draggable is AbstractReactorType || draggable is AbstractDraggablePrinter || draggable is DraggableStorageTank)
                {
                    newPriority++;
                    if (newPriority != draggable.priority)
                    {
                        // Building a tooltip is expensive, so only rebuild it if the priority changes.
                        draggable.priority = newPriority;
                        string nameBackup = draggable.name;
                        draggable.name = String.Format("{0} ({1})", nameBackup, newPriority);
                        draggable.MakeTooltip();
                        draggable.name = nameBackup;
                    }
                }
            }
            this.OriginalRenderProduction(spriteBatch);
        }

        public void OriginalRenderProduction(SpriteBatch spriteBatch) { }

        [Decoy("GetEnumerator")]
        public IEnumerator<KeyValuePair<AbstractDraggable, Vector2i>> GetEnumerator()
        {
            return null;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return null;
        }
    }
}
