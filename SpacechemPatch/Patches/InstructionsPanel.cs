using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qIpvi1Wv355CGDb5l9YJLogv$$4Zjh3CDjc3cu_ahihg=")]
    internal sealed class InstructionsPanel
    {
        [Decoy("#=qgGv9d8WexjZjXkoiqGlt_w==")]
        public Reactor reactor;

        [Decoy(".ctor")]
        public InstructionsPanel(Reactor reactor, HashSet<Type> availableInstructions)
        {

        }

        [Replaced("#=qlEhbYRGUGuTC2mYPd10pNw==", Patch.DefaultDebondInDisassemblyReactors, KeepOriginal = true, NewNameForOriginal = "OriginalAddInstruction")]
        public void AddInstruction(KeyboardButton key, Optional<AbstractInstruction> instruction, string name, string description)
        {
            if (instruction.isPresent && instruction.GetValue() is BondInstruction && reactor.reactorScreen.reactorType is ReactorProductionDisassembly)
            {
                instruction = new BondInstruction(reactor, BondType.Minus);
            }
            OriginalAddInstruction(key, instruction, name, description);
        }

        public void OriginalAddInstruction(KeyboardButton key, Optional<AbstractInstruction> instruction, string name, string description)
        {

        }
    }
}
