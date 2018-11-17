using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qkT0tBhXp89DGtszojsdeygN$RoLg7fOF$VWNqDzaPu0=")]
    internal class RightClickMenu<T>
    {
        [Decoy(".ctor")]
        public RightClickMenu(Optional<string> title)
        {

        }

        [Decoy("#=q4jNqleUohYOS6cAKrOZDhg==")]
        public virtual void Show(IEnumerable<T> selectedElements, Vector2i position)
        {

        }
    }
}
