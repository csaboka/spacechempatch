namespace SpacechemPatch.Patches
{
    [Decoy("#=qqC60YH9eL7nVxVeHV2L4D707tbZfxtYtT3Yl9jgfZj_W39CBigyUDQPzPEj4I01c")]
    abstract class ResearchNetPuzzleDefinition
    {
        [Decoy("#=qJS52Q0s5WNgHMkHVyRGqDXFaM0WlX03wDHll2HiGKbBCZuAM2mSI6scOa4hSL97J")]
        public abstract bool IsIncompatibleWith(ResearchNetPuzzleDefinition definition);

        [Decoy("#=qdF7My9Z0ImSiDeMprbILuA==")]
        public abstract void Init();

        [Decoy("#=qVEhtCjvTuNUzW3aKSV$g6V2nhb2QKRaDS743hL10PkQ=")]
        public sealed class MoleculeAndCount
        {
            [Decoy("#=qCQ0ldOB_AtDsw0EbITo5Zg==")]
            public MoleculeDefinition molecule;
            [Decoy("#=qv8rpL9eRMRqEUS1YjrmSFg==")]
            public int count;
        }
    }
}