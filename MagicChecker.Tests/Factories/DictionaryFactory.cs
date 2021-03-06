using System.Collections.Generic;
using System;
using Microsoft.Pex.Framework;

namespace System.Collections.Generic
{
    /// <summary>A factory for System.Collections.Generic.Dictionary`2[System.String,System.Int32] instances</summary>
    public static partial class DictionaryFactory
    {
        /// <summary>A factory for System.Collections.Generic.Dictionary`2[System.String,System.Int32] instances</summary>
        [PexFactoryMethod(typeof(Dictionary<string, int>))]
        public static Dictionary<string, int> Create(int capacity_i, string key_s, int value_i1)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>(capacity_i);
            dictionary[key_s] = value_i1;
            return dictionary;

            // TODO: Edit factory method of Dictionary`2<String,Int32>
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
