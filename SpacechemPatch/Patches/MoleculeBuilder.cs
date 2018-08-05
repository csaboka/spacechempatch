using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qizm4ojOwvlTMpLo$a0WBiCtBqI8HXvlnqWAOG4kqA1CxBzyu3$y4DebuBfVWxRKQ")]
    class MoleculeBuilder
    {
        [Replaced(".ctor", Patch.AllowGreekInResNet, Patch.AllowGreekInResNetProdAndSandbox, KeepOriginal = true)]
        public MoleculeBuilder(bool bool1, bool bool2, MoleculeDefinition molecule, Action<MoleculeDefinition> action, bool showGreek = false)
            : this(bool1, bool2, molecule, action, true, Original.INSTANCE)
        {

        }

        public MoleculeBuilder(bool bool1, bool bool2, MoleculeDefinition molecule, Action<MoleculeDefinition> action, bool showGreek, Original dummy)
        {

        }
    }
}
