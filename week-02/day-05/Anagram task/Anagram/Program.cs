using System;

namespace Anagram
{
    class Program
    {
        public static void IsAnagram()
        {
            //Ask for user input
            Console.WriteLine("Please give a short word");
            string input1 = Console.ReadLine();
            input1 = input1.ToLower();
            Console.WriteLine("Please give another short word and I will tell you if they are anagrams of eachother or not");
            string input2 = Console.ReadLine();
            input2 = input2.ToLower();

            //Turn strings into arrays and then sort them
            char[] array1 = input1.ToCharArray();
            char[] array2 = input2.ToCharArray();
            Array.Sort(array1);
            Array.Sort(array2);

            //Turn them back to strings
            string sorted1 = new string(array1);
            string sorted2 = new string(array2);

            //Check with if statement if they are the same
            if (sorted1 == sorted2)
            {
                Console.WriteLine("Yes, the word " + input1 + " and " + input2 + " are anagrams");
            }
            else
            {
                Console.WriteLine("Unfortunately, the word " + input1 + " and " + input2 + " are not anagrams");
            }
        }

        static void Main(string[] args)
        {
            IsAnagram();
            Console.ReadLine();
        }
    }
}
