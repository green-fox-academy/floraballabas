using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a recursive function that takes one parameter: n and counts down from n.
            Recursive(20);
            Console.ReadLine();
        }

        private static void Recursive(int n)
        {
            if (n < 0)
                return;
            Console.WriteLine(n);
            Recursive(n - 1);
        }
    }
}
