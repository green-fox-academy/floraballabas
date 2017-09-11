using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 16;
            int currentMinutes = 22;
            int currentSeconds = 30;

            int remainingHours = 24 - currentHours;
            int remaingMinutes = 59 - currentMinutes;
            int remainingSeconds = 59 - currentSeconds;

            Console.WriteLine(remainingHours * 3600 + remaingMinutes *60 + remainingSeconds);

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented bt the variables
        }
    }
}
