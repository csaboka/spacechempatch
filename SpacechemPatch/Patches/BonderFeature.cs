using System;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qxxRrE0U2EIfozdVZOaULNbKFnOET_UqJAsKEIpyyF8I=")]
    class BonderFeature : AbstractFeature
    {
        [Replaced("#=qWQJ$dMDcjxjokRp8n71Fzg==", Patch.ShowBonderPriority, KeepOriginal = true)]
        public override void Render(SpriteBatch spriteBatch, Vector2i position, ReactorLayer layer, Color color, float zOrder, ImageSize imageSize, bool forDragAndDrop)
        {
            Render(spriteBatch, position, layer, color, zOrder, imageSize, forDragAndDrop, Original.INSTANCE);
            if (ownerReactor != null && !forDragAndDrop && imageSize == ImageSize.Normal)
            {
                int priority = 1;
                foreach (ReactorMember member in ownerReactor.GetMembers())
                {
                    if (member == this)
                    {
                        break;
                    }
                    else if (member is BonderFeature)
                    {
                        priority++;
                    }
                }
                string priorityString = priority.ToString();
                Vector2i labelSize = FontManager.normal.GetRenderedSize(priorityString);
                Vector2i labelPosition = new Vector2i(position.x + image.GetDimensions().x - labelSize.x, position.y);
                spriteBatch.AddText(FontManager.normal, priorityString, labelPosition, GetFeatureColor() * color, 0, new Vector2i(), 1, FlipOptions.None, zOrder);
            }
        }

        public void Render(SpriteBatch spriteBatch, Vector2i position, ReactorLayer layer, Color color, float zOrder, ImageSize imageSize, bool forDragAndDrop, Original dummy)
        {

        }
    }
}
