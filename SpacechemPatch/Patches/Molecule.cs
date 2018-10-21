using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qmjx00zzSUp0ar3TWZczE6zlkYCxYh5oRkV4hx8wOh2jOdvbo0eSeo5E5qkQxkq1z")]
    internal sealed class Molecule
    {
        [Decoy("#=qPkoa9v9L4HpYkMcH2wQsyyFoTaLMMSR1VnQpB9q73uU=")]
        public readonly Dictionary<Waldo, Vector2f> WaldoPullVectors = null;

        [Decoy(".ctor")]
        public Molecule(MoleculeDefinition definition, Reactor reactor)
        {

        }

        [Decoy("#=q9C8LRkZEItMDN8wUHbSBZw==")]
        public MoleculeDefinition GetTransformedDefinition(Vector2i negativeOffset)
        {
            return null;
        }
    }
}
