using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=q50Yq9Me1s2AJ5uIhhU6V4lraWdgGLyXTw28eWbPrhLcMyyxIinZa6Urcp2WHCq$Z")]
    class ResearchNetResearchPuzzleDefinition : ResearchNetPuzzleDefinition
    {
        [Decoy("#=qj$7ctc_l8lJFlBXgEYlp_rh$sUtKyJB$86Eevhy3yFs=")]
        public bool hasLargeOutput;

        [Decoy("#=qZzEDLn39qw2lxJkBzXdFzQ==")]
        public byte bonderCount;

        [Decoy("#=qSYL_cJGOnSP7Y$CPRjnNzA==")]
        public bool hasSensor;

        [Injected]
        [JsonProperty("sensor-count")]
        private int sensorCount;

        [Decoy("#=qY7CUccv1cgELRN4Oxg0$KQ==")]
        public bool hasFuser;

        [Injected]
        [JsonProperty("fuser-count")]
        private int fuserCount;

        [Decoy("#=qjKJUsnrWwgdOLCHSvnX3cw==")]
        public bool hasSplitter;

        [Injected]
        [JsonProperty("splitter-count")]
        private int splitterCount;

        [Decoy("#=q0N2YMnjKg2_vdae29jXJOQ==")]
        public bool hasTeleporter;

        [Injected]
        [JsonProperty("teleporter-count")]
        private int teleporterCount;

        [Replaced("#=qJS52Q0s5WNgHMkHVyRGqDXFaM0WlX03wDHll2HiGKbBCZuAM2mSI6scOa4hSL97J", Patch.MoreFeaturesInResNetResearch)]
        public override bool IsIncompatibleWith(ResearchNetPuzzleDefinition definition)
        {
            ResearchNetResearchPuzzleDefinition otherDef = definition as ResearchNetResearchPuzzleDefinition;
            if (otherDef == null)
                return false;
            // The enum constants aren't available at runtime, so we can't use Enum.GetValues().
            // The best we can do is to hardcode the last enum member like this.
            for (int i = 0; i <= (int)FeatureType.Splitter; i++)
            {
                FeatureType featureType = (FeatureType)i;
                if (GetFeatureCount(featureType) != otherDef.GetFeatureCount(featureType))
                {
                    return true;
                }
            }
            return false;
        }

        [Replaced("#=qdF7My9Z0ImSiDeMprbILuA==", Patch.MoreFeaturesInResNetResearch, KeepOriginal = true, NewNameForOriginal = "OriginalInit")]
        public override void Init()
        {
            // make sure our new counter fields agree with the original booleans
            sensorCount = (hasSensor) ? MathUtils.Clamp(1, 4, sensorCount) : 0;
            fuserCount = (hasFuser) ? MathUtils.Clamp(1, 4, fuserCount) : 0;
            splitterCount = (hasSplitter) ? MathUtils.Clamp(1, 4, splitterCount) : 0;
            teleporterCount = (hasTeleporter) ? MathUtils.Clamp(2, 4, teleporterCount) : 0;

            OriginalInit();
        }

        public void OriginalInit()
        {

        }

        [Injected]
        public int GetFeatureCount(FeatureType type)
        {
            switch (type)
            {
                case FeatureType.Bonder:
                    return bonderCount;
                case FeatureType.Fuser:
                    return (hasFuser) ? MathUtils.Clamp(1, 4, fuserCount) : 0;
                case FeatureType.Sensor:
                    return (hasSensor) ? MathUtils.Clamp(1, 4, sensorCount) : 0;
                case FeatureType.Splitter:
                    return (hasSplitter) ? MathUtils.Clamp(1, 4, splitterCount) : 0;
                case FeatureType.Teleporter:
                    return (hasTeleporter) ? MathUtils.Clamp(2, 4, teleporterCount) : 0;
                default:
                    return 0;
            }
        }

        [Injected]
        public void SetFeatureCount(FeatureType type, int count)
        {
            switch (type)
            {
                case FeatureType.Bonder:
                    bonderCount = (byte)count;
                    break;
                case FeatureType.Fuser:
                    fuserCount = count;
                    hasFuser = (count > 0);
                    break;
                case FeatureType.Sensor:
                    sensorCount = count;
                    hasSensor = (count > 0);
                    break;
                case FeatureType.Splitter:
                    splitterCount = count;
                    hasSplitter = (count > 0);
                    break;
                case FeatureType.Teleporter:
                    teleporterCount = count;
                    hasTeleporter = (count > 0);
                    break;
            }
        }

        [Decoy("#=q39ulrHCaIbRwWgaeMcWXyQ==")]
        public sealed class Inputs
        {
            [Decoy("#=qUCdShVP5cRtybGImHpYbVA==")]
            public List<MoleculeAndCount> molecules;
        }
    }
}
