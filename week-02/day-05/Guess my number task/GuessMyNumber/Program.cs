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
            Console.WriteLine("Let's start. You have 5 lives!");
            int input = 0;
            int lives = 5;
            
            while (input != guessNumber && lives != 0)
            {
                input = int.Parse(Console.ReadLine());
                if (input > guessNumber)
                {
                    Console.WriteLine("My number is lower");
                    lives--;
                    Console.WriteLine("You have "+lives+"lives left");
                }
                else if (input < guessNumber)
                {
                    Console.WriteLine("My number is higher");
                    lives--;
                    Console.WriteLine("You have " + lives + "lives left");
                }
                if (input != guessNumber)
                    Console.WriteLine("Try to guess which number I am thinking of");
            }
            if (input == guessNumber)
            {
                Console.WriteLine("You found the number: "+guessNumber);
            }
            else if (lives == 0)
            {
                Console.WriteLine("You are out of lives. Better luck next time!");
            }
            Console.ReadLine();
        }
    }
}
