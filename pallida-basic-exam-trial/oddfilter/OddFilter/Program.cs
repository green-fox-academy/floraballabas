using System;
using System.Collections.Generic;

namespace OddFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an OddFilter function that takes a list as a parameter,
            // and returns a new list with every odd element from the orignal list

            // In case of the example input above, the given PrintList function should print 1 3 5 
            PrintList();

            Console.ReadLine();
        }
        public static void OddFilter()
        {
            var toBeSorted = new List<int> { 1, 2, 3, 4, 5 };
            var oddElements = new List<int>();

            for (int i = 0; i < toBeSorted.Count; i++)
            {
                if (toBeSorted[i] % 2 != 0)
                {
                    oddElements.Add(toBeSorted[i]);
                }
            }
            foreach (int odd in oddElements)
            {
                Console.Write(odd);
            }
        }
        public static void PrintList()
        {
            foreach (int odd in )
            {
                Console.Write("{0} ", element);
            }
        }
    }
}

