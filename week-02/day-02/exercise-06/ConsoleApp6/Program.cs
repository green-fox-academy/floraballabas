using System;

namespace ConsoleApp6
{
    class Program
    {

        static void Main(string[] args)
        {
            // - Create a function called `printer`
            //   which prints the input String parameters
            // - It can have any number of parameters

            // Examples
            // printer("first")
            // printer("first", "second")
            // printer("first", "second", "third", "fourh")
            // ...
            string[] parameter = { "first", "second", "third" };
            Printer(parameter);
        }

        public static void Printer(string[] parameter)
        {
            for (int i = 0; i < parameter.Length; i++)
            {

                Console.WriteLine(parameter[i]);
            }
            Console.ReadKey();
        }
    }
}
