using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to get the squared value of the positive numbers from the following array:

            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            //Query syntax
            var scoreQuery = from square in n
                             where square > 0
                             select Math.Pow(square, 2);
            foreach (var squarenum in scoreQuery)
            {
                Console.WriteLine(squarenum);
            }

            //Method syntax
            var scoreQueryWithLambda = n.Where(square => square > 0).Select(square => Math.Pow(square, 2));
            foreach (var squarenum in scoreQueryWithLambda)
            {
                Console.WriteLine(squarenum);
            }
            Console.ReadLine();
        }
    }
}
