using System.Collections.Generic;

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

        static PatchInfo()
        {
            void AddDef(Patch patch, PatchType patchType, string description) =>
                allPatches.Add(patch, new PatchInfo(patchType, description));

            AddDef(Patch.ShowBonderPriority, PatchType.Enhancement, "Adds the priority number to the bonder tooltip");
            AddDef(Patch.FixWrongOutput, PatchType.Bugfix, "Fixes the \"Wrong Output\" bug");
            AddDef(Patch.AllowGreekInResNetProdAndSandbox, PatchType.Bugfix,
                   "Adds full support for Greek sensors/annotations in ResearchNet production and sandbox assignments");
            AddDef(Patch.AllowGreekInResNet, PatchType.Cheat,
                   "Adds full support for Greek sensors/annotations in all ResearchNet assignments");
        }

        private PatchInfo(PatchType type, string description)
        {
            this.Type = type;
            this.Description = description;
        }

    }
}
