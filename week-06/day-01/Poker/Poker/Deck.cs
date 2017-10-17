using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class Deck
    {
        string[] cardSuit = new string[] { "C", "D", "H", "S" };
        string[] cardValue = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "T", "J", "Q", "K", "A" };
        List<string> cardDeck = new List<string>();

        public List<string> GenerateDeck()
        {
            foreach (var suit in cardSuit)
            {
                foreach (var value in cardValue)
                {
                    cardDeck.Add(value + suit);
                }
            }
            return cardDeck;
        }
        public List<string> CardDeck
            {
                get
                {
                    return cardDeck;
                }
            }

    }
}
