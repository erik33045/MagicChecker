using MagicChecker.Models;
using System.Collections.Generic;
using System.Linq;

namespace MagicChecker.Repository
{
    public class CardComparer
    {
        public static List<Card> CompareList(List<Card> CardsToFind, Dictionary<string, int> Collection)
        {
            //If either collection is null, return null
            if (CardsToFind == null || !CardsToFind.Any() || Collection == null || !Collection.Any())
                return null;

            //If there are any cards that are null or have null names, return null
            if (CardsToFind.Any(x => x == null || x.Name == null || x.Name == ""))
                return null;

            var returnList = new List<Card>();

            CardsToFind.ForEach(cardToFind =>
            {                
                if (Collection.Keys.Any(key => key == cardToFind.Name))
                {
                    var hit = Collection[cardToFind.Name];

                    returnList.Add(new Card
                    {
                        Name = cardToFind.Name,
                        //If the quantity found is greater than the requested, only give the number requested. Otherwise, give available quantity.
                        Quantity = hit >= cardToFind.Quantity 
                            ? cardToFind.Quantity 
                            : hit
                    });
                }

            });

            return returnList;
        }
    }
}
