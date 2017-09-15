using System;

namespace Palindrome
{
    class Program
    {
        public static void IsPalindrome()
        {
            //Create a function named create palindrome following your current language's style guide. 
            //It should take a string, create a palindrome from it and then return it.
            //Ask for user input
            Console.WriteLine("Please give a word");
            string input1 = Console.ReadLine();

            //Save it in a new string, then turn it to array and reverse it
            string input2 = input1;
            char[] reversed = input2.ToCharArray();
            Array.Reverse(reversed);
            //turn it back to string
            string reversedInput = new string(reversed);

            //Print the two strings together
            Console.WriteLine("Here is your word and it's palindrome: " + input1 + reversedInput);
        }

        static void Main(string[] args)
        {
            IsPalindrome();
            Console.ReadLine();

        }
    }
}
