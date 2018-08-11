using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qBdkKGWictHDMwxeo8bJsHoB9ItTZsqp4pJcUslpzUQq2GtiWj7VD1hz8yfy943iq")]
    abstract class AbstractFeature : AbstractReactorMember
    {
        [Decoy("#=qvLdwtLps354HcCd_QGnqmg==")]
        public Image image;
        [Decoy("#=qGgv6HTvjLM$FgBaHDKEweA==")]
        protected FeatureTooltip featureTooltip;

        [Decoy(".ctor")]
        public AbstractFeature(Reactor reactor, Image image, bool unknown, string title, Vector2i size)
        {

        }

    }
}
