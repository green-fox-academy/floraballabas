using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number form the standard input,
            // Than prints "Odd" if the number is odd, or "Even" it it is even.

            Console.WriteLine("Write a number");
            int input = int.Parse(Console. ReadLine());

            if (input % 2 == 0)
            {
                Console.WriteLine("Your number is even!");
            }
            else {
                Console.WriteLine("Your number is odd");
            }
            Console.ReadLine();
        }
    }
}
