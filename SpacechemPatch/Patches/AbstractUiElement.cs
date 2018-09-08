using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qzw21PDVpgBEgpFsc1Bn5TthNWkRfIR00ae5kHzc3Phc=")]
    abstract class AbstractUiElement
    {
        [Decoy("#=qiMnF_huDZ_gmIgHP9WL2aQ==")]
        public static AbstractUiElement LayoutVertically(HorizontalAlignment alignment, int padding, IEnumerable<AbstractUiElement> elements)
        {
            return null;
        }

        [Decoy("#=qfDMTCIghGlyoYmF_fQ$UOQ==")]
        public static AbstractUiElement LayoutHorizontally(VerticalAlignment alignment, int padding, IEnumerable<AbstractUiElement> elements)
        {
            return null;
        }
    }
}
