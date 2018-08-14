namespace SpacechemPatch.Patches
{
    [Decoy("#=qO8NYVVhhdx0dagnPcNZySHg70HX5ks_hK6GPyBHuB9mnkY_FgjJpgJ6pzHg3Zg75")]
    internal class ProductionPuzzle : AbstractPuzzle
    {
        [Decoy(".ctor")]
        public ProductionPuzzle(bool flipFlopsAvailable)
            : base(flipFlopsAvailable)
        {
        }
    }
}