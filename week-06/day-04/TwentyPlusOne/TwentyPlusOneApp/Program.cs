using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOneApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var deck = new Deck(52);
            Console.WriteLine();
            deck.ShuffleDeck();
            Console.WriteLine();

            var topcard = deck.PullFirst();
            Console.WriteLine(topcard.GetCard());
            var lastcard = deck.PullLast();
            Console.WriteLine(lastcard.GetCard());
            var randomcard = deck.PullRandom();
            Console.WriteLine(randomcard.GetCard());
            Console.ReadLine();
        }
    }
}
