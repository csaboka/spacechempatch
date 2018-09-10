using System;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qxxRrE0U2EIfozdVZOaULNbKFnOET_UqJAsKEIpyyF8I=")]
    class BonderFeature : AbstractFeature
    {
        [Decoy(".ctor")]
        public BonderFeature(Reactor reactor)
            : base(reactor, null, false, null, new Vector2i())  // This is just to make the compiler happy, it's _not_ the real base constructor call!
        {

        }

        [Replaced("#=qWQJ$dMDcjxjokRp8n71Fzg==", Patch.ShowBonderPriority, KeepOriginal = true, NewNameForOriginal = "OriginalRender")]
        public override void Render(SpriteBatch spriteBatch, Vector2i position, ReactorLayer layer, Color color, float zOrder, ImageSize imageSize, bool forDragAndDrop)
        {
            OriginalRender(spriteBatch, position, layer, color, zOrder, imageSize, forDragAndDrop);
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
                RenderPriority(spriteBatch, position, color, zOrder, priority);
            }
        }

        public void OriginalRender(SpriteBatch spriteBatch, Vector2i position, ReactorLayer layer, Color color, float zOrder, ImageSize imageSize, bool forDragAndDrop)
        {

        }
    }
}
