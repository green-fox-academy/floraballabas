using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one

            Console.WriteLine("Please write a number");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("Please write a second number");
            int input1 = int.Parse(Console.ReadLine());

            if (input > input1)
            {
                Console.WriteLine("The bigger number is " + input);
            }
            else
            {
                Console.WriteLine("The bigger number is " + input1);
            }
            Console.ReadLine();

        }
    }
}
