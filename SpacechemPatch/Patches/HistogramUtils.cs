namespace SpacechemPatch.Patches
{
    [Decoy("#=qhkF0CmcrJUkV9xkX5gPBlzOuBZy_PoMwnFmfNaACw98=")]
    internal static class HistogramUtils
    {
        [Decoy("#=qVPs7qUBscolbMB_1tBs$Kiar6bv73SHpTxtMSnTBuOM=")]
        public static readonly string elapsedCycles;
        [Decoy("#=qa94IyBM5a4OAThG7nyHZ7Cee4HO7QVfh9mUyovzW1$c=")]
        public static readonly string reactorsUsed;
        [Decoy("#=qNFAjCEFWJKoXWtRXIBzsA$TltxuWThl$MVqEzqMkt8U=")]
        public static readonly string symbolsUsed;

        [Replaced("#=qOCZYiIko0mI05FIEcXOhbPxTWIiHT5e9RX_CZQsX24s=", Patch.DeclassifyDefenses, KeepOriginal = true, NewNameForOriginal = "OriginalMakeLeaderboard")]
        public static AbstractRenderable MakeLeaderboard(Optional<MetricLeaderboard> metricLB, Optional<int> bestMetric,
                                                         string label, bool noLevel, bool isDefense, bool inTF2)
        {
            // isDefense controls if a placeholder is shown instead of the LB, so make it always false
            return OriginalMakeLeaderboard(metricLB, bestMetric, label, noLevel, false, inTF2);
        }

        public static AbstractRenderable OriginalMakeLeaderboard(Optional<MetricLeaderboard> metricLB, Optional<int> bestMetric,
                                                                 string label, bool noLevel, bool isDefense, bool inTF2) => null;

        [Replaced("#=qnrFQrgVQj$TL7kg0UMYODA==", Patch.DeclassifyDefenses, KeepOriginal = true, NewNameForOriginal = "OriginalMakeHistogram")]
        public static AbstractRenderable MakeHistogram(Optional<string> metricHistBars, Optional<int> thisMetric, Optional<int> bestMetric,
                                                       string lineName, string metricName, bool noLevel, bool isDefense, bool inTF2)
        {
            // isDefense controls if a placeholder is shown instead of the hist, so make it always false
            return OriginalMakeHistogram(metricHistBars, thisMetric, bestMetric, lineName, metricName, noLevel, false, inTF2);
        }

        public static AbstractRenderable OriginalMakeHistogram(Optional<string> metricHistBars, Optional<int> thisMetric, Optional<int> bestMetric,
                                                               string lineName, string metricName, bool noLevel, bool isDefense, bool inTF2) => null;
    }
}
