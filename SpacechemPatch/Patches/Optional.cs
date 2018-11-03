using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qH$Tj31UdqF3a6L3mdG7E_P_6$Khp27qRyVbKuPLLLLs=")]
    struct Optional<T>
    {
        [Decoy("#=quhcSEqqTojXjELlMkqU5Ww==")]
        public static readonly Optional<T> ABSENT;
        [Decoy("#=qn51$HnaqmlmIaen7axiKig==")]
        public readonly bool isPresent;
        [Decoy("#=qRCwFqSCqte76EEPxr$2SMQ==")]
        public readonly T value;

        [Decoy(".ctor")]
        private Optional(bool isPresent, T value)
        {
            this.isPresent = isPresent;
            this.value = value;
        }

        [Decoy("#=qE7ovXWVF5_HojnPCLTh8nA==")]
        public T GetValue()
        {
            return default(T);
        }

        [Decoy("op_Implicit")]
        public static implicit operator Optional<T>(T value)
        {
            return default(T);
        }

        [Decoy("op_Implicit")]
        public static implicit operator Optional<T>(Empty empty) => null;

        // Decoy not working, see issue #29
        // [Decoy("#=qlBxHrgCjtWGhQv19sAWzSA==")]
        // public Optional<TResult> Transform<TResult>(Func<T, TResult> transformation) => null;
    }
}
