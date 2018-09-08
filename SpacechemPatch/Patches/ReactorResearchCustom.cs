using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qzMEZMr9SKcbR3qzXYmOQ0KVJlBbvXePl8mdmof5Wn19yiwGuhmevtUxTunWMRm5ASKEVvjQoe4eeib9Wf1l_tg==")]
    internal class ReactorResearchCustom : AbstractReactorType
    {
        [Decoy("#=qTuoJSbE9D4zxCjjChU2k_w==")]
        private ResearchNetResearchPuzzleDefinition puzzleDefinition;

        [Replaced("#=qUbHp5$s3KImaIfEBJ9eSVPnfR23Pjt$xgY0igWPpU0E=", Patch.MoreFeaturesInResNetResearch)]
        public override void SetCapabilities()
        {
            puzzleDefinition = UserManager.GetCurrentUser().GetSolutionManager().puzzleDefinition as ResearchNetResearchPuzzleDefinition;
            if (puzzleDefinition.bonderCount > 0)
            {
                availableInstructions.Add(typeof(BondInstruction));
                availableFeatures.Add(typeof(BonderFeature), puzzleDefinition.bonderCount);
            }
            if (puzzleDefinition.hasSensor)
            {
                availableInstructions.Add(typeof(SensorInstruction));
                availableFeatures.Add(typeof(SensorFeature), puzzleDefinition.GetFeatureCount(FeatureType.Sensor));
            }
            if (puzzleDefinition.hasFuser)
            {
                availableInstructions.Add(typeof(FuseInstruction));
                availableFeatures.Add(typeof(FuserFeature), puzzleDefinition.GetFeatureCount(FeatureType.Fuser));
            }
            if (puzzleDefinition.hasSplitter)
            {
                availableInstructions.Add(typeof(SplitInstruction));
                availableFeatures.Add(typeof(SplitterFeature), puzzleDefinition.GetFeatureCount(FeatureType.Splitter));
            }
            if (!puzzleDefinition.hasTeleporter)
                return;
            availableInstructions.Add(typeof(SwapInstruction));
            availableFeatures.Add(typeof(QuantumTunnelFeature), puzzleDefinition.GetFeatureCount(FeatureType.Teleporter));
        }

        [Replaced("#=qZ$yOTUfUfAGGQwHZPgocUnYKNxJE8HodIOC4cj$dDpY=", Patch.MoreFeaturesInResNetResearch)]
        public override void InitializeReactor()
        {
            if (puzzleDefinition.hasLargeOutput)
                reactorScreen = new LargeOutputReactorArea(this);
            else
                reactorScreen = new ReactorScreen(this);
            Reactor reactor = new Reactor(reactorScreen, new Vector2i(117, 4), new Vector2i(10, 8), puzzleDefinition.hasLargeOutput ? ReactorLayout.LargeOutput : ReactorLayout.Regular, false);
            reactorScreen.reactor = reactor;
            if (!HasExistingReactor() && !Constants.unknown1)
            {
                AddStartInstructions();
                Vector2i firstBonderPosition = new Vector2i(4, 3 - (puzzleDefinition.bonderCount - 1) / 4);
                for (int i = 0; i < puzzleDefinition.bonderCount; ++i)
                {
                    reactor.AddMember(new Vector2i(firstBonderPosition.x + i % 2, firstBonderPosition.y + i / 2), ReactorLayer.Background, new BonderFeature(reactor));
                }
                for (int i = 0; i < puzzleDefinition.GetFeatureCount(FeatureType.Sensor); i++)
                {
                    Vector2i position = new Vector2i(2 + i % 2, 3 - i / 2);
                    reactor.AddMember(position, ReactorLayer.Background, new SensorFeature(reactor));
                }
                for (int i = 0; i < puzzleDefinition.GetFeatureCount(FeatureType.Splitter); i++)
                {
                    reactor.AddMember(new Vector2i(6, 4 + i), ReactorLayer.Background, new SplitterFeature(reactor));
                }
                for (int i = 0; i < puzzleDefinition.GetFeatureCount(FeatureType.Fuser); i++)
                {
                    reactor.AddMember(new Vector2i(6, 3 - i), ReactorLayer.Background, new FuserFeature(reactor));
                }
                for (int i = 0; i < puzzleDefinition.GetFeatureCount(FeatureType.Teleporter); i++)
                {
                    Vector2i position = new Vector2i(2 + i % 2, 4 + i / 2);
                    reactor.AddMember(position, ReactorLayer.Background, new QuantumTunnelFeature(reactor));
                }
            }
            reactorScreen.instructionsPanel = new InstructionsPanel(reactor, availableInstructions);
            reactorScreen.simulationEngine = new ReactorSimulationEngine(reactor);
        }
    }
}
