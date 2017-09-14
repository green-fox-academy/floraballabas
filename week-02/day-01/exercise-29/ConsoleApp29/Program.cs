using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // pyramid like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //
            // The pyramid should have as many lines as the number was

            Console.WriteLine("Please give a number");
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                for (int j = 1; j <= input - i; j++)
                    Console.Write(" ");
                
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                    Console.Write("\n");
            }

                Console.ReadLine();
        }
    }
}
