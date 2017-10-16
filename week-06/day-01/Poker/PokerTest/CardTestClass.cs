using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poker;

namespace PokerTest
{
    [TestFixture]
    class CardTestClass
    {
        [Test]
        public void TestWithString()
        {
            string expected = "2H";
            var cardAtHand = new Cards(expected);
            Assert.IsTrue(cardAtHand.IsItAcceptable(expected));
        }
        [Test]
        public void TestWithTooLongString()
        {
            string expected = "2Hkj";
            var cardAtHand = new Cards(expected);
            Assert.IsFalse(cardAtHand.IsItAcceptable(expected));
        }
    }
}
