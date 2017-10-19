using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOneApp
{
    class Deck
    {
        Random random = new Random();
        List<Card> deckOfCards = new List<Card>();
        List<int> listByColor = new List<int>();

        public Deck(int numberOfCards)
        {
            MakeColorDifferent();
            while (listByColor.Count < numberOfCards)
            {
                listByColor.Add(random.Next(0, 4));
            }
            for (int i = 0; i < numberOfCards; i++)
            {
                deckOfCards.Add(new Card((CardColor)random.Next(typeof(CardColor).GetEnumNames().Length),
                    (CardSuit)random.Next(typeof(CardSuit).GetEnumNames().Length),
                    (CardRank)random.Next(typeof(CardRank).GetEnumNames().Length)));
            }
            foreach (var card in deckOfCards)
            {
                Console.WriteLine(card.GetCard());
            }
        }
        public List<Card> DeckOfCards
        {
            get
            {
                return deckOfCards;
            }
            set
            {
                deckOfCards = value;
            }
        }
        public void MakeColorDifferent()
        {
            for (int i = 0; i < 4; i++)
            {
                int suit = random.Next(0, 4);
                while (listByColor.Contains(suit))
                {
                    suit = random.Next(0, 4);
                }
                listByColor.Add(suit);
            }
        }

        public void ShuffleDeck()
        {
            List<int> deckOfShuffledCards = new List<int>();
            List<Card> shuffledDeck = new List<Card>();
            for (int i = 0; i < deckOfCards.Count; i++)
            {
                int indexOfCard = random.Next(0, deckOfCards.Count);
                while (deckOfShuffledCards.Contains(indexOfCard))
                {
                    indexOfCard = random.Next(0, deckOfCards.Count);
                }
                deckOfShuffledCards.Add(indexOfCard);
            }
            foreach (int index in deckOfShuffledCards)
            {
                shuffledDeck.Add(deckOfCards[index]);
            }
            for (int i = 0; i < deckOfCards.Count; i++)
            {
                deckOfCards[i] = shuffledDeck[i];
            }
            foreach (var card in deckOfCards)
            {
                Console.WriteLine(card.GetCard());
            }
        }
        //    public Card DrawTopCard()
        //    {
        //        var cardDrawn = deckOfCards[0];
        //        deckOfCards.RemoveAt(0);
        //        return cardDrawn;
        //    }
    }
}
