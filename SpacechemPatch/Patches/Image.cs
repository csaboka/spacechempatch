using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("#=qe_isvAJEJ1HEnC6KWOWQu8BOqiUmhc0JXLqzOBrMYIEw8LeJZcXMnIJKXI3j$v4C")]
    class Image
    {
        [Decoy(".ctor")]
        public Image(string s)
        {

        }

        [Decoy("#=qFQKWIotwwkD7rczoirRCQw==")]
        public Vector2i GetDimensions()
        {
            return new Vector2i();
        }
    }
}
