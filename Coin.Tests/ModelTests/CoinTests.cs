using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coin.Method;
using System;
using System.Collections.Generic;

namespace Coin.Tests 
{
    [TestClass]
    public class CoinTest
    {
        [TestMethod]
        public void InstVarConstructor_CreatesInstanceOfWord_CoinCombination() {
            CoinCombination testInstance = new CoinCombination(108);
            Assert.AreEqual(typeof(CoinCombination), testInstance.GetType());
        }

        [TestMethod]
        public void ChangeCounter_OutputCorrectChange_CorrectOutput() {
            CoinCombination testInstance = new CoinCombination(25);
            Assert.AreEqual("1 quarter", testInstance.ChangeCounter());
        }
    }
}