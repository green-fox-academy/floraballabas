using System;

namespace DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a function that takes a number
            // divides ten with it,
            // and prints the result.
            // it should print "fail" if the parameter is 0

            Console.WriteLine("Please give a number");
            int userInput = int.Parse(Console.ReadLine());
            int number = 10;
            try
            {
                int result = number / userInput;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("fail");
            }
            Console.ReadLine();
        }
    }
}
