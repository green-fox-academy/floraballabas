using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the frequency of characters in a given string!
            string toBeChecked = "kiscica";

            //Query Syntax
            var frequencyOfCharacters = from character in toBeChecked
                                        group character by character into uniqueChars
                                        select new { uniqueChars.Key, Count = uniqueChars.Count() };
            foreach (var character in frequencyOfCharacters)
            {
                Console.WriteLine("Letter {0} appears {1} times in the string", character.Key, character.Count);
            }

            Console.WriteLine();

            //Method syntax
            var frequencyOfCharactersWithLambda = toBeChecked.GroupBy(character => character).ToDictionary
                (character => character.Key, character => character.Count());
            foreach (var character in frequencyOfCharactersWithLambda)
            {
                Console.WriteLine("Letter {0} appears {1} times in the string", character.Key, character.Value);
            }
            Console.ReadLine();
        }
    }
}
