using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            int b = 526;
            int c = a + b;

            a = c - a;
            b = c - b;
            Console.WriteLine(b);
        }
    }
}
