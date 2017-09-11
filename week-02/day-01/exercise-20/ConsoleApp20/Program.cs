using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers
            // Thw first number represents the number of girls that comes to a party, the
            // second the boys

            Console.WriteLine("Please write a number");
            int girls = int.Parse(Console.ReadLine());
            Console.WriteLine("Please write a second number");
            int boys = int.Parse(Console.ReadLine());

            int people = girls + boys;
            // It should print: The party is exellent!
            // If the the number of girls and boys are equal and there are more people coming than 20
            if (girls == 0)
            {
                Console.WriteLine("Sausage party");
            }
            // It should print: Quite cool party!
            // It there are more than 20 people coming but the girl - boy ratio is not 1-1
            else if (girls != boys && people >= 20)
            {
                Console.WriteLine("Quite cool party!");
            }
            // It should print: Average party...
            // If there are less people coming than 20
            else if (people < 20)
            {
                Console.WriteLine("Avarage party...");
            }
            // It should print: Sausage party
            // If no girls are coming, regardless the count of the people
            else if (girls == boys && people >= 20)
            {
                Console.WriteLine("The party is excellent!");
            }
                Console.ReadKey();
        }
    }
}
