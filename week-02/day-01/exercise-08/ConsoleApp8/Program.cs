using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            int b = 526;

            a = b;
            b = a - 403;
            Console.WriteLine(b);
        }
    }
}
