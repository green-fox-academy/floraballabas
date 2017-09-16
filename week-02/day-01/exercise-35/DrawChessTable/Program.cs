using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crate a program that draws a chess table like this
            //
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            //
            int table = 8;
            for (int i = 1; i <= table; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < 1; j++)
                        Console.Write(" ");
                    for (int j = 0; j < 4; j++)
                        Console.Write("%");
                    Console.WriteLine();
                }
                else
                {
                    for (int j = 0; j < 4; j++)
                        Console.Write("%");
                    Console.WriteLine();
                }
                
            }
            Console.ReadLine();
        }
    }
}
