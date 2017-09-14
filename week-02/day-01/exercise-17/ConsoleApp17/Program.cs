using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4
            Console.WriteLine("Please give a number");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("Please give a number");
            int input1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please give a number");
            int input2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please give a number");
            int input3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please give a number");
            int input4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum: " + (input+input1+input2+input3+input4));
            Console.WriteLine("Avarage: " + (input + input1 + input2 + input3 + input4) / 5);

            Console.ReadLine();

        }
    }
}
