﻿using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `s`
            //   with the following content: `[1, 2, 3, 8, 5, 6]`
            int[] s = {1, 2, 3, 8, 5, 6};
            // - Change the 8 to 4
            s[3] = 4;
            // - Print the fourth element
            Console.WriteLine(s[3]);
            Console.ReadLine();
        }
    }
}
