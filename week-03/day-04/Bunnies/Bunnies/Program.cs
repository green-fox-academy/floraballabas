using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            // We have a number of bunnies and each bunny has two big floppy ears.
            // We want to compute the total number of ears across all the bunnies recursively (without loops or multiplication).
            Console.WriteLine(Recursive(2));
            Console.ReadLine();
        }

        private static int Recursive(int bunny)
        {
            if (bunny == 0)
                return 0;
            return 2 + Recursive(bunny-1);
        }
    }
}
