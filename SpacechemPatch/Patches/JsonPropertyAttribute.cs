using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpacechemPatch.Patches
{
    [Decoy("JsonPropertyAttribute", @namespace="Newtonsoft.Json")]
    class JsonPropertyAttribute : Attribute
    {
        [Decoy(".ctor")]
        public JsonPropertyAttribute(String propertyName)
        {

        }
    }
}
