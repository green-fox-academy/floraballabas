using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAdder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a recursive function that takes one parameter: n and adds numbers from 1 to n.
            Console.WriteLine(Recursive(18));
            Console.ReadLine();
        }

        private static int Recursive(int n)
        {
            if (n == 1)
                return 1;
            return n + Recursive(n -1);
            
        }
    }
}
