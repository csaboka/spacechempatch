using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qrCJREAf$Hf9aGa3TuUSykqD5r_3Ab8bBF_TygfhUUAQ=")]
    class PuzzlesManager
    {
        [Replaced("#=qAgwLmvCteZBjvtnHkOEEwgYmcgQ8QGBZzG19bo74mlw=", Patch.AllowGreekInResearchNet)]
        public static bool DoesPuzzleUseGreekElements(string puzzleName)
        {
            // Instead of looking up the puzzle by name and comparing it against
            // the list of known Greek levels, we look up the inputs of the currently
            // loaded puzzle. If any of the inputs has Greek elements, we show the picker.
            AbstractPuzzle currentPuzzle = GameScreen.GetTopmostScreenWithType<AbstractPuzzle>();
            foreach (KeyValuePair<AbstractDraggable, Vector2i> entry in currentPuzzle.draggableContainer)
            {
                AbstractInput input = entry.Key as AbstractInput;
                if (input != null)
                {
                    foreach (KeyValuePair<MoleculeDefinition, double> inputEntry in input)
                    {
                        foreach (Atom atom in inputEntry.Key.atoms.Values)
                        {
                            if (atom.element.IsUnknownByScience())
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        [Replaced("#=qAgwLmvCteZBjvtnHkOEEwgYmcgQ8QGBZzG19bo74mlw=", Patch.AllowGreekInResearchNetProductionAndSandbox)]
        public static bool DoesPuzzleUseGreekElements_NoResearchPuzzle(string puzzleName)
        {
            // Same logic, but return false for ResNet research puzzles. In the unpatched game,
            // you have no way to get Greek sensors in those levels, so enabling them can
            // be considered cheating.
            AbstractPuzzle currentPuzzle = GameScreen.GetTopmostScreenWithType<AbstractPuzzle>();
            if (currentPuzzle is Puzzle_ResNetResearch)
            {
                return false;
            }
            foreach (KeyValuePair<AbstractDraggable, Vector2i> entry in currentPuzzle.draggableContainer)
            {
                AbstractInput input = entry.Key as AbstractInput;
                if (input != null)
                {
                    foreach (KeyValuePair<MoleculeDefinition, double> inputEntry in input)
                    {
                        foreach (Atom atom in inputEntry.Key.atoms.Values)
                        {
                            if (atom.element.IsUnknownByScience())
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }
    }
}
