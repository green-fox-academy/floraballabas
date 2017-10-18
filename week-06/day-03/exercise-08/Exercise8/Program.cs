using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the uppercase characters in a string!
            string toBeChecked = "KisCica";

            //Query syntax
            var upperCaseQuery = from character in toBeChecked
                                 where Char.IsUpper(character)
                                 select character;

            foreach (var character in upperCaseQuery)
            {
                Console.WriteLine(character);
            }

            //Method syntax
            var upperCaseQueryWithLambda = toBeChecked.Where(character => Char.IsUpper(character)).Select(character => character);

            foreach (var character in upperCaseQueryWithLambda)
            {
                Console.WriteLine(character);
            }

            Console.ReadLine();
        }
    }
}
