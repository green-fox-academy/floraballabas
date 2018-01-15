using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input1 = "rail safety";
            string input2 = "fairy tales";
            CheckAnagram(input1, input2);
            CheckItWithLinq();
            Console.WriteLine(ChecksAnagramWithLinq(input1, input2));
            Console.ReadLine();
        }
        
        public static void CheckAnagram(string input1, string input2)
        {
            char[] array1 = input1.ToCharArray();
            char[] array2 = input2.ToCharArray();
            Array.Sort(array1);
            Array.Sort(array2);

            string sorted1 = new string(array1);
            string sorted2 = new string(array2);

            if (sorted1 == sorted2)
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("Not anagram");
            }
        }
        
        public static void CheckItWithLinq()
        {
            string str1 = "they see";
            string str2 = "the eyes";

            bool isAnagram = (((str1 + str2).Any(c => str1.Count(x => x == c) != str2.Count(x => x == c))));
            if (isAnagram)
            {
                Console.WriteLine("no anagram");
            }
            else
            {
                Console.WriteLine("Anagram");
            }
        }
        
        public static bool ChecksAnagramWithLinq(string input1, string input2)
        {
            var characterArray1 = input1.ToCharArray()
                            .Where(x => Char.IsLetterOrDigit(x))
                            .ToLookup(x => x)
                            .ToDictionary(x => x.Key, x => x.Count());
            var characterArray2 = input2.ToCharArray()
                            .Where(x => Char.IsLetterOrDigit(x))
                            .ToLookup(x => x)
                            .ToDictionary(x => x.Key, x => x.Count());

            bool isAnagram = characterArray1.All(x => characterArray2[x.Key] == characterArray1[x.Key]);
            return isAnagram;
        }
    }
}
