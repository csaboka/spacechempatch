using System.Collections.Generic;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qbAExfYCexqjsy0TU5ZsL1NyYPsgtcs$qTDUNFAic7fcXq_BwXy_Jnqggac8qMIqT")]
    internal class ProductionTerrain : AbstractDraggable
    {
        [Decoy(".ctor")]
        public ProductionTerrain(TextureElement texture, DraggableContainer container, int verticalOffset, HashSet<Vector2i> occupiedSquares, bool gridLinesLessVisible)
        {
        }
    }
}