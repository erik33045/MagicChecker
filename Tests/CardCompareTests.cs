using MagicChecker.Models;
using MagicChecker.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Shouldly;

namespace Tests
{
    [TestClass]
    public class CardCompareTests
    {
        [TestMethod]
        public void Should_Find_Hit()
        {
            var cardsToFind = new List<Card> { new Card { Name = "a", Quantity = 1 } };
            var collection = new Dictionary<string, int> { { "a", 1 } };

            var hits = CardComparer.CompareList(cardsToFind, collection);

            hits.ShouldNotBeEmpty();
        }
    }
}
