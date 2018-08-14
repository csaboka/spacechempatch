using System;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qjb5Ljxc0Pc8gW93GS_EmMC0dA9W8KTT4xSXOazGwL9xupqxCtInPhwXcEOELzqPu")]
    internal class ResearchPuzzle : AbstractPuzzle
    {
        [Decoy(".ctor")]
        public ResearchPuzzle(Type reactorType, bool flipFlopsAvailable)
            : base(flipFlopsAvailable)
        {
        }
    }
}