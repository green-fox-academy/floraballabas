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
    class DeckTestClass
    {
        var deck = new Deck();
        [Test]
        public void TestForCertainDeck()
        {
            string expected = "3H";
            Assert.Contains(expected, deck.);

        }
    }
}
