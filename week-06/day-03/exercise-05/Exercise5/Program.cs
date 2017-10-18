using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the frequency of numbers in the following array:

            int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            //Method syntax
            var freqQueryWithLambda = n.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

            foreach (var query in freqQueryWithLambda)
            {
                Console.WriteLine(query);
            }

            //Query syntax
            var frequencyOfNumbers = from number in n
                                     orderby number ascending
                                     group number by number into uniqeNumber
                                     select new { uniqeNumber.Key, Count = uniqeNumber.Count() };

            foreach (var num in frequencyOfNumbers)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }
    }
}
