using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qBdkKGWictHDMwxeo8bJsHoB9ItTZsqp4pJcUslpzUQq2GtiWj7VD1hz8yfy943iq")]
    abstract class AbstractFeature : ReactorMember
    {
        [Decoy("#=qvLdwtLps354HcCd_QGnqmg==")]
        public Image image;
        [Decoy("#=qGgv6HTvjLM$FgBaHDKEweA==")]
        protected FeatureTooltip featureTooltip;

        [Decoy(".ctor")]
        public AbstractFeature(Reactor reactor, Image image, bool unknown, string title, Vector2i size)
        {

        }

        [Decoy("#=qWQJ$dMDcjxjokRp8n71Fzg==")]
        public override void Render(SpriteBatch spriteBatch, Vector2i position, ReactorLayer layer, Color color, float zOrder, ImageSize imageSize, bool forDragAndDrop)
        {

        }

        [Decoy("#=q6htdcg9vPHtUPeLQfysa7Q==")]
        protected Color GetFeatureColor()
        {
            return new Color();
        }

        [Decoy("#=qPyTV6ED7qEyGENL$3FfBa141FeUQQnZFSvDZkig_3DM=")]
        protected void Activate(bool forRed)
        {

        }

    }
}
