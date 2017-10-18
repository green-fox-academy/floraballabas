using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find which number squared value is more then 20 from the following array:

            int[] n = new[] { 3, 9, 2, 8, 6, 5 };

            var squareQurey = from number in n
                               where Math.Pow(number, 2) > 20
                               select number;
            foreach (var square in squareQurey)
            {
                Console.WriteLine(square);
            }

            var squareQueryWithLambda = n.Where(x => Math.Pow(x, 2) > 20).Select(x => x);

            foreach (var square in squareQueryWithLambda)
            {
                Console.WriteLine(square);
            }
            Console.ReadLine();
        }
    }
}
