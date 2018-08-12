using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qvWkw_yfabtEZtyzamBBBvUk8Udll9pCcz$4UiKOkNz3GpODQcDp9IdyHJxz3yKfG")]
    sealed class BottomRightInfoBox
    {
        [Replaced("#=qpCRb4anQPm6V7O3YSBWP8Q==", Patch.ShowOver100kCycles)]
        private AbstractTextLabel MakeStatLabel(int stat)
        {
            if (stat < 100_000)
                return AbstractTextLabel.MakeLabel(FontManager.tooltip, stat.ToString());
            else if (stat < 10_000_000 )
                return AbstractTextLabel.MakeLabel(FontManager.tooltip, (stat/1000).ToString() + "K");
            else
                return AbstractTextLabel.MakeLabel(FontManager.tooltip, (stat / 1_000_000).ToString() + "M");
        }
    }
}
