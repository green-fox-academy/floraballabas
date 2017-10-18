using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to get the even numbers from the following array:
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            IEnumerable<int> evenQuery = from num in n
                                         where num % 2 ==0
                                         select num;
            foreach (var evenNumber in evenQuery)
            {
                Console.WriteLine(evenNumber);
            }
            Console.ReadLine();
        }
    }
}
