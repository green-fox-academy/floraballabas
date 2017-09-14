using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores a number, and the user has to figure it out.
            // The user can input guesses, after each guess the program would tell one
            // of the following:
            //
            // The stored number is higher
            // The stried number is lower
            // You found the number: 8
            int number = 8;
            //Console.WriteLine("Try to guess which number I am thinking of");
            //int input = int.Parse(Console.ReadLine());
            int input = 0;

            Console.WriteLine("Try to guess which number I am thinking of");

            while (input != number) 
            {
                input = int.Parse(Console.ReadLine());
                if (input > number)
                {
                    Console.WriteLine("The stored number is lower");
                }
                else if (input < number)
                {
                    Console.WriteLine("The stored number is higher");
                }
                Console.WriteLine("Try to guess which number I am thinking of");
            }
            if (input == number)
            {
                Console.WriteLine("You found the number: 8");
            }
            Console.ReadLine();
        }
    }
}
