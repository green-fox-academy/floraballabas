using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSubstring2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a function that takes a string and a list of string as a parameter
            //Returns the index of the string in the list where the first string is part of
            //Returns - 1 if the string is not part any of the strings in the list
            List<string> list = new List<string> { "this", "is", "what", "I'm", "searching", "in" };
            string search = "ching";
            Console.WriteLine(Finder(list, search));
            Console.ReadLine();
        }
        public static int Finder(List<string> list, string search)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Contains(search))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
