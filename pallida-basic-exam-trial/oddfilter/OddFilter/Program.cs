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
            OddFilter();

            Console.ReadLine();
        }
        private static void OddFilter()
        {
            List<int> toBeSorted = new List<int> { };
            List<int> oddElements = new List<int> { };
            Console.WriteLine("Please tell me how many numbers you will enter for me to sort out the odd numbers");
            int numbersCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbersCount; i++)
            {
                Console.WriteLine("Please enter a number");
                int numbers = int.Parse(Console.ReadLine());
                toBeSorted.Add(numbers);
            }

            for (int i = 0; i < toBeSorted.Count; i++)
            {
                if (toBeSorted[i] % 2 != 0)
                    oddElements.Add(toBeSorted[i]);
            }
            Console.WriteLine("These were the odd numbers in your list:");
            foreach (var odd in oddElements)
            {
                Console.Write(odd);
            }
        }
    }
}

