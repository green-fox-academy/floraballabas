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

        public Deck(int numberOfCards)
        {
            for (int i = 0; i < numberOfCards; i++)
            {
                if (i < numberOfCards / 2)
                {
                    deckOfCards.Add(new Card(CardColor.Black,
                    (CardSuit)random.Next(typeof(CardSuit).GetEnumNames().Length),
                    (CardRank)random.Next(typeof(CardRank).GetEnumNames().Length)));
                }
                else
                {
                    deckOfCards.Add(new Card(CardColor.Red,
                    (CardSuit)random.Next(typeof(CardSuit).GetEnumNames().Length),
                    (CardRank)random.Next(typeof(CardRank).GetEnumNames().Length)));
                }
                
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

        public Card PullFirst()
        {
            var cardDrawn = deckOfCards[0];
            deckOfCards.RemoveAt(0);
            return cardDrawn;
        }

        public Card PullLast()
        {
            var cardDrawn = deckOfCards[deckOfCards.Count -1];
            deckOfCards.RemoveAt(deckOfCards.Count -1);
            return cardDrawn;
        }
        public Card PullRandom()
        {
            int indexToRemove = random.Next(0, deckOfCards.Count - 1);
            var cardDrawn = deckOfCards[indexToRemove];
            deckOfCards.RemoveAt(indexToRemove);
            return cardDrawn;
        }
    }
}
