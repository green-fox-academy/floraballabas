using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for an integer that is a distance in kilometers,
            // then it converts that value to miles and prints it

            Console.WriteLine("How many kms can you run?");
            int km = int.Parse(Console.ReadLine());

            Console.WriteLine("Wow, that is " + km * 0.62 + "miles");
            Console.ReadLine();
        }
    }
}
