using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("Vector2i", @namespace = "Impeller")]
    public struct Vector2i
    {
        [Decoy("#=qGV0w7kQYbQhuIHYpzGvEkA==")]
        public static readonly Vector2i NULL = new Vector2i();

        [Decoy("#=qQeZspJ4Xad5R9_RFi53Asw==")]
        public int x;
        [Decoy("#=qPkNd7qcHpcMBBXqDfc5GPQ==")]
        public int y;

        [Decoy(".ctor")]
        public Vector2i(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        [Decoy(".ctor")]
        public Vector2i(Vector2i vector)
        {
            x = vector.x;
            y = vector.y;
        }

        [Decoy("op_Multiply")]
        public static Vector2f operator *(Vector2i vector, float multiplier)
        {
            return new Vector2f();
        }

        [Decoy("op_Addition")]
        public static Vector2i operator +(Vector2i left, Vector2i right)
        {
            return new Vector2i();
        }

        [Decoy("op_Division")]
        public static Vector2i operator /(Vector2i left, int right)
        {
            return new Vector2i();
        }

        [Decoy("op_Subtraction")]
        public static Vector2i operator -(Vector2i vector2i_9, Vector2i vector2i_10)
        {
            return new Vector2i();
        }

        [Decoy("op_Implicit")]
        public static implicit operator Vector2f(Vector2i vector)
        {
            return new Vector2f();
        }
    }
}
