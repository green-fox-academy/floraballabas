using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively a new string where all the
            // adjacent chars are now separated by a "*".
            string input = "kiscica";
            Console.WriteLine(Recursive(input));
            Console.ReadLine();
        }

        private static string Recursive(string input)
        {
            if (input.Length == 1)
                return input;
            else
                return input[0] + "*" + Recursive(input.Substring(1)); 
        }
    }
}
