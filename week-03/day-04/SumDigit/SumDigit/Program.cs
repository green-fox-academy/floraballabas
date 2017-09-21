using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a non-negative int n, return the sum of its digits recursively (no loops). 
            // Note that mod (%) by 10 yields the rightmost digit (126 % 10 is 6), while 
            // divide (/) by 10 removes the rightmost digit (126 / 10 is 12).
            Console.WriteLine(Recursion(8));
            Console.ReadLine();
        }
        private static int Recursion(int n)
        {
            if (n != 0)
                return n % 10 + Recursion(n / 10);
            else
                return 0;
        }
    }
}
