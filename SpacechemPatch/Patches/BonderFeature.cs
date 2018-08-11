using System;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qxxRrE0U2EIfozdVZOaULNbKFnOET_UqJAsKEIpyyF8I=")]
    class BonderFeature : AbstractFeature
    {
        [Replaced(".ctor", Patch.ShowBonderPriority)]
        public BonderFeature(Reactor reactor)
            : base(reactor, new Image("reactor/bondifier"), false, Localization.Localize("Bonder"), new Vector2i(39, 39))
        {
            int priority = 1;
            System.Collections.IEnumerable enumerable = reactor.GetMembers();
            foreach (object member in enumerable)
            {
                if (member == this)
                {
                    break;
                } else if (member is BonderFeature)
                {
                    priority++;
                }
            }
            featureTooltip = FeatureTooltip.Make(Localization.Localize("Bonder") + " (" + priority + ")",
                Localization.Localize("Adds or removes bonds from atoms when activated by the \"Add / Remove Bond\" instruction. Bonders can be connected by placing them adjacent to each other."),
                new Optional<UnknownStruct1>());
        }
    }
}
