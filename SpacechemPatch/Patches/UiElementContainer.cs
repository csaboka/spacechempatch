using System.Collections.Generic;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qtof8a3RC8Q7zDPANiyJeJxWDfGvlZVh22V7iM7k6Wts=")]
    internal class UiElementContainer : AbstractUiElement
    {
        [Decoy("#=qi32BOElqKZkMdqyhWwGi2g==")]
        private List<ContainedUiElement> elements;

        [Decoy(".ctor")]
        public UiElementContainer(IEnumerable<ContainedUiElement> elements)
        {
        }
    }
}