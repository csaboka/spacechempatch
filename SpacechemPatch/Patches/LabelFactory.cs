using System;

namespace SpacechemPatch.Patches
{
    [Decoy("#=q5EVa_6qiWW78THvUYCxIaYivRLSKBZQ_fyFgAG9C3Ik=")]
    internal static class LabelFactory
    {
        [Decoy("#=qla_FrBrg_Kmf6k6zymHOPO3NZ_Ezny7Jw1K7Ki2x8NU=")]
        public static readonly Color paleBlue;
        [Decoy("#=qXfBCXU9Vj70t0yAekzIL1QzRXEI7Hq3brz6HFObOnWU=")]
        public static readonly Color gray;
        [Decoy("#=qXgD66aITrpljU8WhJNsDFT8obntNrc5h6yUwMDsCQ_Y=")]
        public static readonly Color lightBlue;
        [Decoy("#=qzsKUygckEZ3OT_hRUrn4wW_Nme4Hm2sXWWGnWG5U8MY=")]
        public static readonly Color darkBlue;
        [Decoy("#=qkR8ivVRwPN2EsxpXOYllKiCN$tLGKUtPCGTUlbErMHE=")]
        public static readonly Color darkYellow;
        [Decoy("#=quGDeGK4PnlmAkv_aDpnRK20kcY9TVdaBydQxmkV2E70=")]
        public static readonly Color cement;

        [Decoy("#=qApuPsyTBoPWfrZxffqm$9w==")]
        public static Button MakeButtonWithContent(AbstractRenderable content, Vector2i size, Action action) => null;
    }
}