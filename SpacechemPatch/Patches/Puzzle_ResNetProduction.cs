using System.Collections.Generic;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qMX6$iZBEiHwFQYvb_MY_iHn1Bq8Fd_wO8vCm_2VcKZNWBSf2cqQp5yay4vDkW4j7")]
    internal class Puzzle_ResNetProduction : ProductionPuzzle
    {
        [Replaced(".ctor", Patch.ResNetProdCustomAmount)]
        public Puzzle_ResNetProduction()
          : base(true)
        {
            ResearchNetProductionPuzzleDefinition definition = UserManager.GetCurrentUser().GetSolutionManager().puzzleDefinition as ResearchNetProductionPuzzleDefinition;

            ResearchNetResearchPuzzleDefinition.Inputs randomInputMolecules;
            if (definition.randomInputZones.TryGetValue(0, out randomInputMolecules) && randomInputMolecules.molecules.Count > 0)
            {
                Dictionary<MoleculeDefinition, int> randomMoleculesCount = new Dictionary<MoleculeDefinition, int>();
                foreach (ResearchNetPuzzleDefinition.MoleculeAndCount moleculeAndCount in randomInputMolecules.molecules)
                    randomMoleculesCount[moleculeAndCount.molecule] = moleculeAndCount.count;
                ProductionUtils.AddInputStorageTank(randomMoleculesCount, draggableContainer, new Vector2i(1, 5), new Vector2i(16, 17));
            }

            MoleculeDefinition fixedInputMolecule;
            if (definition.fixedInputZones.TryGetValue(0, out fixedInputMolecule))
                ProductionUtils.AddInputStorageTank(new Dictionary<MoleculeDefinition, int>()
                {
                    {
                        fixedInputMolecule,
                        1
                    }
                }, draggableContainer, new Vector2i(3, 13), new Vector2i(16, 348));
            if (definition.fixedInputZones.TryGetValue(1, out fixedInputMolecule))
                ProductionUtils.AddInputStorageTank(new Dictionary<MoleculeDefinition, int>()
                {
                    {
                        fixedInputMolecule,
                        1
                    }
                }, draggableContainer, new Vector2i(3, 18), new Vector2i(16, 490));

            ResearchNetPuzzleDefinition.MoleculeAndCount outputMoleculeAndCount;
            if (definition.outputZones.TryGetValue(0, out outputMoleculeAndCount))
                ProductionUtils.AddOutputCargoFreighter(outputMoleculeAndCount.molecule, draggableContainer, new Vector2i(23, 2), outputMoleculeAndCount.count * 4);
            if (definition.outputZones.TryGetValue(1, out outputMoleculeAndCount))
                ProductionUtils.AddOutputCargoFreighter(outputMoleculeAndCount.molecule, draggableContainer, new Vector2i(23, 7), outputMoleculeAndCount.count * 4);
            if (definition.outputZones.TryGetValue(2, out outputMoleculeAndCount))
                ProductionUtils.AddOutputCargoFreighter(outputMoleculeAndCount.molecule, draggableContainer, new Vector2i(23, 12), outputMoleculeAndCount.count * 4);

            if (definition.hasRecycler)
                ProductionUtils.AddRecycler(draggableContainer, new Vector2i(24, 17));
            maxReactors = definition.maxReactors;

            ResearchNetProductionPuzzleDefinition.Terrain terrain = ResearchNetProductionPuzzleDefinition.terrains[definition.terrain];
            if (terrain.isMining)
                draggableContainer.PutDraggableAtCoords(0, 0, new MiningProductionTerrain(draggableContainer, terrain.verticalOffset, terrain.occupiedSquares, terrain.gridLinesLessVisible));
            else
                draggableContainer.PutDraggableAtCoords(0, 0, new ProductionTerrain(terrain.terrainTexture, draggableContainer, terrain.verticalOffset, terrain.occupiedSquares, terrain.gridLinesLessVisible));
        }
    }
}
