namespace SpacechemPatch.Patches
{
    [Decoy("#=qRx7ZfPnU_oTBF0cGYkaGvuWAPvS478krajKgfxLowe72jz3UhMX6QvkfGxi6IxYe")]
    sealed class MinusOnlyBonderFeature : BonderFeature
    {
        [Replaced(".ctor", Patch.ShowBonderPriority)]
        public MinusOnlyBonderFeature(Reactor reactor)
          : base(reactor)
        {
            this.image = new Image("reactor/bondifier_minusonly");
            int priority = 1;
            if (reactor != null)    // we may be called with a null reactor in the bonding introduction level
            {
                System.Collections.IEnumerable enumerable = reactor.GetMembers();
                foreach (object member in enumerable)
                {
                    if (member is BonderFeature)
                    {
                        priority++;
                    }
                }
            }
            featureTooltip = FeatureTooltip.Make(Localization.Localize("Bonder (Remove Only)") + " (" + priority + ")",
                Localization.Localize("A bonder that can only remove bonds."), new Optional<UnknownStruct1>());
        }
    }
}
