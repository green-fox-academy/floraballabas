using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to get the average value of the odd numbers from the following array:

            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var oddQuery = (from odd in n
                            where odd % 2 == 1 || odd % 2 == -1
                            select odd).Average();
            Console.WriteLine(oddQuery);

            var oddQueryWithLambda = n.Where(y => y % 2 == 1 || y % 2 == -1).Average();
            Console.WriteLine(oddQueryWithLambda);

            Console.ReadLine();
        }
    }
}