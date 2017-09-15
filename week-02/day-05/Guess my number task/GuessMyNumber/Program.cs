using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program where the program chooses a number between 1 and 100.The player is then asked to enter a guess. If the player guesses wrong, then the program gives feedback and ask to enter an other guess until the guess is correct.
            //Make the range customizable(ask for it before starting the guessing).
            //You can add lives. (optional)

            Console.WriteLine("Let's play Guess my number! Give me where should the range start");
            int range1 = int.Parse(Console.ReadLine());
            Console.WriteLine("And what should be the top range?");
            int range2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Allright, I will think of a number between "+range1+" and "+range2);
            Random random = new Random();
            int guessNumber = random.Next(range1, range2);
            Console.WriteLine("Let's start. Make your guess!");
            int input = 0;

            while (input != guessNumber)
            {
                input = int.Parse(Console.ReadLine());
                if (input > guessNumber)
                {
                    Console.WriteLine("My number is lower");
                }
                else if (input < guessNumber)
                {
                    Console.WriteLine("My number is higher");
                }
                Console.WriteLine("Try to guess which number I am thinking of");
            }
            if (input == guessNumber)
            {
                Console.WriteLine("You found the number: "+guessNumber);
            }
            Console.ReadLine();
        }
    }
}
