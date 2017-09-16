using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // diamond like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //  *****
            //   ***
            //    *
            //
            // The diamond should have as many lines as the number was
            Console.WriteLine("Please enter a number");
            int lines = int.Parse(Console.ReadLine());

            for (int i = 1; i <= ((lines/2)+1); i++)
            {
                for (int j = 0; j < lines - i; j++)
                    Console.Write(" ");
                for (int j = 0; j < i*2-1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }

            for (int i = lines/2; i >= 0; i--)
            {
                for (int j = 0; j < lines - i; j++)
                    Console.Write(" ");
                for (int j = 0; j < i * 2 - 1; j++)
                    Console.Write("*");
                Console.WriteLine();
               
            }
            Console.ReadLine();
        }
    }
}
