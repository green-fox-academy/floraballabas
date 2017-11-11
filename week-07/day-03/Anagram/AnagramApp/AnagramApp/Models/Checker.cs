using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnagramApp.Models
{
    public class Checker
    {
        public bool IsAnagram { get; set; }
        public string Input1 { get; set; }
        public string Input2 { get; set; }

        public void AnagramCheck()
        {
            char[] array1 = Input1.ToCharArray();
            char[] array2 = Input2.ToCharArray();
            Array.Sort(array1);
            Array.Sort(array2);
            
            string sorted1 = new string(array1);
            string sorted2 = new string(array2);
            
            if (sorted1 == sorted2)
            {
                IsAnagram = true;
            }
            else
            {
                IsAnagram = false;
            }
        }
    }
}
