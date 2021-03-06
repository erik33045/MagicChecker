using Microsoft.Pex.Framework;
using MagicChecker.Models;

namespace System.Collections.Generic
{
    public static partial class CardFactory
    {
        [PexFactoryMethod(typeof(Card))]
        public static Card Create(string name, int quantity)
        {
            return new Card
            {
                Name = name,
                Quantity = quantity
            };            
        }
    }
}
