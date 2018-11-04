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
            AddDef(Patch.AllowBondsForUnknownInNotes, PatchType.Enhancement,
                "Allows adding bonds to the unknown element (?) when editing output notes.",
                Patch.AllowIllegalBondsInResNet);
            AddDef(Patch.AllowGreekInResNet, PatchType.Cheat,
                   "Adds full support for Greek sensors/annotations in all ResearchNet assignments",
                   Patch.AllowGreekInResNetProdAndSandbox);
            AddDef(Patch.AllowGreekInResNetProdAndSandbox, PatchType.Enhancement,
                   "Adds full support for Greek sensors/annotations in ResearchNet production and sandbox assignments",
                   Patch.AllowGreekInResNet);
            AddDef(Patch.AllowIllegalBondsInResNet, PatchType.Cheat,
                "Allows any bonds to be specified when editing ResearchNet puzzles, even if they exceed the bond limit.",
                Patch.AllowBondsForUnknownInNotes);
            AddDef(Patch.DefaultDebondInDisassemblyReactors, PatchType.Enhancement,
                   "Replace the Bond+ instruction with Bond- in disassembly reactor toolbars, since Bond+ is useless in them");
            AddDef(Patch.FixTelekinesis, PatchType.Bugfix, "Fixes the \"Telekinesis\" bug");
            AddDef(Patch.FixWrongOutput, PatchType.Bugfix, "Fixes the \"Wrong Output\" bug");
            AddDef(Patch.ForceLinuxMoleculeOrder, PatchType.Enhancement,
                "Generate random input molecules the same way the vanilla Linux version does, regardless of OS",
                Patch.ForceWindowsMoleculeOrder);
            AddDef(Patch.ForceWindowsMoleculeOrder, PatchType.Enhancement,
                "Generate random input molecules the same way the vanilla Windows version does, regardless of OS",
                Patch.ForceLinuxMoleculeOrder);
            AddDef(Patch.MoreFeaturesInResNetResearch, PatchType.Cheat,
                "Adds the ability to have more fusers, splitters, sensors and quantum tunnels " +
                "in custom ResearchNet research puzzles");
            AddDef(Patch.RemoveYouTubeUpload, PatchType.Enhancement,
                "Removes the broken YouTube upload functionality. Videos are always saved to the desktop instead.");
            AddDef(Patch.ResNetProdCustomAmount, PatchType.Cheat,
                   "Allows ResNet production puzzles output count to be specified in the input JSON. Count is 4x JSON count");
            AddDef(Patch.ReverseOrderCustomResNetAssignments, PatchType.Enhancement,
                   "Reverses the display order of custom ResearchNet puzzles so the most recent is listed first.");
            AddDef(Patch.ShowBonderPriority, PatchType.Enhancement, "Adds the priority number next to the bonder");
            AddDef(Patch.ShowOver100kCycles, PatchType.Enhancement,
                   "Shows the cycles number even if it's over 100k, by shortening it");
            AddDef(Patch.ShowReactorPriority, PatchType.Enhancement,
                "Shows the priority of reactors, tanks and printers in the tooltip.");
            AddDef(Patch.StricterCollisionChecks, PatchType.Bugfix,
                "Fix most collision bugs by introducing some new collision checks and changing the timing of some others.");
            AddDef(Patch.SuperFastForward, PatchType.Enhancement,
                   "Runs the simulation at maximum speed if you click on the fastest speed button while holding down Ctrl");
        }

        private PatchInfo(PatchType type, string description, Patch[] conflictingPatches)
        {
            this.Type = type;
            this.Description = description;
            this.ConflictingPatches = conflictingPatches;
        }

    }
}
