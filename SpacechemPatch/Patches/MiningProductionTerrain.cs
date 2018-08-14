using System.Collections.Generic;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qB82POvxYQAlojhql9swHZk6rk3lgHckquLJFr8Upy7nB2FhJFAl1wxfWy6cyLIY9")]
    internal class MiningProductionTerrain : ProductionTerrain
    {
        [Decoy(".ctor")]
        public MiningProductionTerrain(DraggableContainer container, int verticalOffset, HashSet<Vector2i> occupiedSquares, bool gridLinesLessVisible)
            : base(ResourceUtils.LoadResource<TextureElement>("terrain/mining"), container, verticalOffset, occupiedSquares, gridLinesLessVisible)
        {
        }
    }
}