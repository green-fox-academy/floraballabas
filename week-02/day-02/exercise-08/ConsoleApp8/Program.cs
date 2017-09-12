using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `p1`
            //   with the following content: `[1, 2, 3]`
            int[] p1 = {1, 2, 3};
            // - Create an array variable named `p2`
            //   with the following content: `[4, 5]`
            int[] p2 = { 4, 5 };
            // - Print if `p2` has more elements than `p1`

            if (p2.Length > p1.Length)
            {
                Console.WriteLine("p2 has more elements then p1");
            }
            else
            {
                Console.WriteLine("p1 has more elements than p2");
            }
            Console.ReadLine();
        }
    }
}
