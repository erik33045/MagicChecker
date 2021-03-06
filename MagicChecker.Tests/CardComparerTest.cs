// <copyright file="CardComparerTest.cs">Copyright ©  2016</copyright>
using System;
using System.Collections.Generic;
using MagicChecker.Models;
using MagicChecker.Repository;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MagicChecker.Repository.Tests
{
    /// <summary>This class contains parameterized unit tests for CardComparer</summary>
    [PexClass(typeof(CardComparer))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class CardComparerTest
    {
        /// <summary>Test stub for CompareList(List`1&lt;Card&gt;, Dictionary`2&lt;String,Int32&gt;)</summary>
        [PexMethod]
        public List<Card> CompareListTest(List<Card> CardsToFind, Dictionary<string, int> Collection)
        {
            List<Card> result = CardComparer.CompareList(CardsToFind, Collection);
            return result;
            // TODO: add assertions to method CardComparerTest.CompareListTest(List`1<Card>, Dictionary`2<String,Int32>)
        }
    }
}
