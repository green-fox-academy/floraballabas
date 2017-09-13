using System;
using System.Collections.Generic;
using System.Text;

namespace Matchmaking
{
    public class Matchmaking
    {
        public static void Main(string[] args)
        {
            // Join the two lists by matching one girl with one boy in the order list
            // Exepected output: "Eve", "Joe", "Ashley", "Fred"...

            var girls = new List<string> { "Eve", "Ashley", "Bözsi", "Kat", "Jane" };
            var boys = new List<string> { "Joe", "Fred", "Béla", "Todd", "Neef", "Jeff" };
            var order = new List<string>();

            for (int i = 0; i < girls.Count; i++)
            {
                order.Add(girls[i]);
                order.Add(boys[i]);
            }

            if (girls.Count + boys.Count != order.Count)
            {
                order.Add(boys[5]);
            }

            foreach (var or in order)
            {
                Console.WriteLine(or);
            }
            Console.ReadLine();
        }
    }
}