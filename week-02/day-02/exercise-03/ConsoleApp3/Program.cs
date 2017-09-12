using System;

namespace ConsoleApp3
{
    class Program
    {
        // - Create a string variable named `am` and assign the value `kuty` to it
        // - Write a function called `appendA` that gets a string as an input
        //   and appends an 'a' character to its end
        // - Print the result of `appendA(am)`

        public static void AppendA()
        {
            string am = "kuty";
            Console.WriteLine(am+"a");
        }
        static void Main(string[] args)
        {
            AppendA();
            Console.ReadLine();
        }
    }
}
