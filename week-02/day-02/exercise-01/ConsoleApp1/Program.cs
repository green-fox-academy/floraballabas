using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Doubling()
        {
            int ak = 123;
            ak *= 2;
            Console.WriteLine(ak);
        }

        static void Main(string[] args)
        {
            // - Create an integer variable named `ak` and assign the value `123` to it
            // - Create a function called `doubling` that doubles it's input parameter
            // - Print the result of `doubling(ak)`

            Doubling();
            Console.ReadLine();
        }
    }
}
