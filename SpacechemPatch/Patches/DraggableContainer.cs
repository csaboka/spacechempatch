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
