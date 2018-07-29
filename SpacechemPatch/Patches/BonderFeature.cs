using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qxxRrE0U2EIfozdVZOaULNbKFnOET_UqJAsKEIpyyF8I=")]
    class BonderFeature : AbstractFeature
    {
        [Replaced(".ctor")]
        public BonderFeature(Reactor reactor)
            : base(reactor, new IconMaybe("reactor/bondifier"), false, Localization.Localize("Bonder"), new Vector2i(39, 39))
        {
            featureTooltip = FeatureTooltip.Make(Localization.Localize("Bonder"), "Hello, world!", new Optional<UnknownStruct1>());
        }
    }
}
