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
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        J,
        Q,
        K,
        A
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
