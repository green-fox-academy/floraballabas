using System;

namespace PalindromeSearcher
{
    class Program
    {
        public static void SearchPalindrom()
        {
            //Create a function named search palindrome following your current language's style guide. 
            //It should take a string, search for palindromes that at least 3 characters long and return a list with the found palindromes.
            Console.WriteLine("Please enter a string");
            string input = Console.ReadLine();

            char[] array = input.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                //if (array[i] != array[array.Length - 1 -i])
                //{
                //  return false;
                //}
            }
            return true;
        }

        static void Main(string[] args)
        {
            
            SearchPalindrom();
            Console.ReadLine();
        }
    }
}
