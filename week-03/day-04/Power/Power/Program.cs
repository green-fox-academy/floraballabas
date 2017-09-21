using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given base and n that are both 1 or more, compute recursively (no loops)
            // the value of base to the n power, so powerN(3, 2) is 9 (3 squared).
            Console.WriteLine(Recursive(4, 2));
            Console.ReadLine();
        }

        private static int Recursive(int b, int n)
        {
            if (b == 0 || n == 0)
                return 1;
            return b * Recursive( b, n - 1);
        }
    }
}
