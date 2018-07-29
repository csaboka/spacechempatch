using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qBdkKGWictHDMwxeo8bJsHoB9ItTZsqp4pJcUslpzUQq2GtiWj7VD1hz8yfy943iq")]
    abstract class AbstractFeature : AbstractReactorMember
    {
        [Decoy(".ctor")]
        public AbstractFeature(Reactor reactor, IconMaybe icon, bool unknown, string title, Vector2i size)
        {

        }

        [Decoy("#=qGgv6HTvjLM$FgBaHDKEweA==")]
        protected FeatureTooltip featureTooltip;
    }
}
