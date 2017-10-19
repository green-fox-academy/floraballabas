using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOneApp
{
    public enum CardColor {Black, Red}
    public enum CardSuit {Club, Diamond, Spade, Heart}
    public enum CardRank
    {
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        J = 10,
        Q = 10,
        K = 10,
        A = 11
    }

    class Card
    {
        public CardColor Color;
        public CardSuit Suit;
        public CardRank Rank;

        public Card(CardColor color, CardSuit suit, CardRank rank)
        {
            this.Color = color;
            this.Suit = suit;
            this.Rank = rank;
        }

        public string GetCard()
        {
            return String.Format("{0} {1} {2}", Color, Suit, Rank);
        }
    }
}
