﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class MainPokerClass
    {
        static void Main(string[] args)
        {
            var deck = new Deck();
            deck.GenerateDeck();
            Console.ReadLine();
        }
    }
}
