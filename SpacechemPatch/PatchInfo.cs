using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SpacechemPatch
{
    class PatchInfo
    {
        public enum PatchType
        {
            Enhancement,
            Bugfix,
            Cheat
        }

        public static readonly Dictionary<Patch, PatchInfo> allPatches = new Dictionary<Patch, PatchInfo>();

        public PatchType Type { get; }
        public string Description { get; }
        public Patch[] ConflictingPatches { get; }

        private static void AddDef(Patch patch, PatchType patchType, string description, params Patch[] conflictingPatches)
        {
            Debug.Assert(!conflictingPatches.Contains(patch));
            allPatches.Add(patch, new PatchInfo(patchType, description, conflictingPatches));
        }

        static PatchInfo()
        {
            AddDef(Patch.ShowBonderPriority, PatchType.Enhancement, "Adds the priority number next to the bonder");
            AddDef(Patch.FixWrongOutput, PatchType.Bugfix, "Fixes the \"Wrong Output\" bug");
            AddDef(Patch.AllowGreekInResNetProdAndSandbox, PatchType.Enhancement,
                   "Adds full support for Greek sensors/annotations in ResearchNet production and sandbox assignments",
                   Patch.AllowGreekInResNet);
            AddDef(Patch.AllowGreekInResNet, PatchType.Cheat,
                   "Adds full support for Greek sensors/annotations in all ResearchNet assignments",
                   Patch.AllowGreekInResNetProdAndSandbox);
            AddDef(Patch.ShowOver100kCycles, PatchType.Enhancement,
                   "Shows the cycles number even if it's over 100k, by shortening it");
            AddDef(Patch.ResNetProdCustomAmount, PatchType.Cheat,
                   "Allows ResNet production puzzles output count to be specified in the input JSON. Count is 4x JSON count");
        }

        private PatchInfo(PatchType type, string description, Patch[] conflictingPatches)
        {
            this.Type = type;
            this.Description = description;
            this.ConflictingPatches = conflictingPatches;
        }

    }
}
