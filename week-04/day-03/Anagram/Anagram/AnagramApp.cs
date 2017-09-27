using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    public class AnagramApp
    {
        public bool IsAnagram(string input1, string input2)
        {
            input1 = input1.ToLower();
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
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
