namespace SpacechemPatch.Patches
{
    [Decoy("#=q5y3FY6n4K4qD_zbNUoqw$C8oqPAt01KzbzJktIjIMt$fKwUqNJWJr$xFP4eJfQgk")]
    sealed class PlusOnlyBonderFeature : BonderFeature
    {
        [Replaced(".ctor", Patch.ShowBonderPriority)]
        public PlusOnlyBonderFeature(Reactor reactor)
          : base(reactor)
        {
            this.image = new Image("reactor/bondifier_plusonly");
            int priority = 1;
            System.Collections.IEnumerable enumerable = reactor.GetMembers();
            foreach (object member in enumerable)
            {
                if (member is BonderFeature)
                {
                    priority++;
                }
            }
            featureTooltip = FeatureTooltip.Make(Localization.Localize("Bonder (Add Only)") + " (" + priority + ")",
                Localization.Localize("A bonder that can only add bonds."), new Optional<UnknownStruct1>());
        }
    }
}