using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qAPy3XyZU$q0nKNPxKiUODhzfbIxKun63Jk5YcjYkZFI0O7bljUAFHZ58THguIWcA")]
    internal sealed class ResNetResearchEditorScreen
    {
        [Decoy("#=qOAott1Amxj45JPYrUkpR6w==")]
        private readonly ResearchNetResearchPuzzleDefinition puzzleDefinition;

        [Replaced("#=qe1fXzA$JmlssIxKRqa3Hvl0NfdpODrXji$ZUwOesWdo=", Patch.MoreFeaturesInResNetResearch)]
        private AbstractUiElement BuildReactorComponentsOptions()
        {
            // in-line array initialization causes the compiler to emit some code the patcher doesn't
            // support at the moment, so we'll initialize the arrays in the tedious long-hand way.
            int[] bonderCountOptions = new int[4];
            bonderCountOptions[0] = 0;
            bonderCountOptions[1] = 2;
            bonderCountOptions[2] = 4;
            bonderCountOptions[3] = 8;

            int[] extendedFeatureCountOptions = new int[5];
            for (int i = 0; i < 5; i++)
            {
                extendedFeatureCountOptions[i] = i;
            }

            int[] tunnelCountOptions = new int[4];
            tunnelCountOptions[0] = 0;
            tunnelCountOptions[1] = 2;
            tunnelCountOptions[2] = 3;
            tunnelCountOptions[3] = 4;

            AbstractUiElement[] firstRow = new AbstractUiElement[3];
            firstRow[0] = BuildReactorComponentOption(FeatureType.Bonder, bonderCountOptions);
            firstRow[1] = BuildReactorComponentOption(FeatureType.Sensor, extendedFeatureCountOptions);
            firstRow[2] = BuildReactorComponentOption(FeatureType.Teleporter, tunnelCountOptions);

            AbstractUiElement[] secondRow = new AbstractUiElement[2];
            secondRow[0] = BuildReactorComponentOption(FeatureType.Fuser, extendedFeatureCountOptions);
            secondRow[1] = BuildReactorComponentOption(FeatureType.Splitter, extendedFeatureCountOptions);

            AbstractUiElement[] rows = new AbstractUiElement[2];
            // Adjust the horizontal padding from 30px to 20px so the content won't overflow
            rows[0] = AbstractUiElement.LayoutHorizontally(VerticalAlignment.Center, 20, firstRow);
            rows[1] = AbstractUiElement.LayoutHorizontally(VerticalAlignment.Center, 20, secondRow);

            return AbstractUiElement.LayoutVertically(HorizontalAlignment.Center, 20, rows);
        }

        [Decoy("#=qmi3bzadshn8UJnJX1lyAVwgG6dLVPLtTDjFKwL62zqw=")]
        private AbstractUiElement BuildReactorComponentOption(FeatureType featureType, int[] allowedCounts)
        {
            return null;
        }

        [Replaced("#=q1ZoWqsSQyY8NUwRhILfC7XDgU2hah0IU5SwY1Oe9LrI=", Patch.MoreFeaturesInResNetResearch)]
        private int GetFeatureCount(FeatureType featureType)
        {
            return puzzleDefinition.GetFeatureCount(featureType);
        }
        
        [Replaced("#=qKpuX1bG5TJXaUS4gu1acI6qf4KtQzAnum9McOpAiUBU=", Patch.MoreFeaturesInResNetResearch)]
        private void UpdateFeatureCount(FeatureType featureType, int count)
        {
            puzzleDefinition.SetFeatureCount(featureType, count);
        }
    }
}
