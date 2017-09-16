using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%
            // %   %
            // %   %
            // %   %
            // %   %
            // %%%%%
            //
            // The square should have as many lines as the number was
            Console.WriteLine("Please tell me how many lines the square should have");
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines - 1; i++)
                Console.Write("%");
            Console.WriteLine();

            for (int i = 0; i < lines-2; i++)
            {
                for (int j = 0; j < 1; j++)
                    Console.Write("%");
                for (int j = 0; j < lines - 3; j++)
                    Console.Write(" ");
                for (int j = 0; j < 1; j++)
                    Console.Write("%");
                Console.WriteLine();
            }

            for (int i = 0; i < lines - 1; i++)
                Console.Write("%");
          
            Console.ReadLine();
        }
    }
}
