using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=q_cxfLpUljKkzjeK3fPMBkG3px6FflpNUVhxoFBvbCyQ=")]
    class SpriteBatch
    {
        [Decoy("#=q2sna6XLVsJYU8lYTMs5EkA==")]
        public void AddText(Font font, string text, Vector2i position, Color color, float float_0, Vector2i offset, float float_1, FlipOptions flipOptions, float zOrder)
        {

        }

        [Decoy("#=qSoNeRR$xCzDxZCl7BvFmLfZnCpfAjVA_7WpITMhrmt0=")]
        public void AddTextCentered(Font font, string text, Vector2i position, Color color, float zOrder)
        {

        }
    }
}
