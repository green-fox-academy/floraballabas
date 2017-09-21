using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively a new string where all the 'x' chars have been removed.
            string input = "xaxxxannaxxa";
            int length = input.Length;
            Console.WriteLine(Recursive(input, length));
            Console.ReadLine();
        }

        private static string Recursive(string input, int length)
        {
            string result;

            if (length == 0)
            {
                return "";
            }
            else
            {
                if (input.Substring(length - 1, 1) == "x")
                {
                    result = "";
                    return Recursive(input, length - 1) + result;
                }
                else
                {
                    return Recursive(input, length - 1) + input.Substring(length - 1, 1);
                }
            }
        }
    }
}
