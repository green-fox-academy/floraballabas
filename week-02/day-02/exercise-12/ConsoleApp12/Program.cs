using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `af`
            //   with the following content: `[4, 5, 6, 7]`
            int[] af = {4, 5, 6, 7};
            // - Print all the elements of `af`
            foreach (int number in af)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
