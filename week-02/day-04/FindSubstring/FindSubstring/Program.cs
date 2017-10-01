using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a function that takes two strings as a parameter
            //Returns the starting index where the second one is starting in the first one
            //Returns - 1 if the second string is not in the first one
            string toBeSearched = "this is what I'm searching in";
            string Searcher = "searching";
            Console.WriteLine(Finder(toBeSearched, Searcher));
            Console.ReadLine();
        }
        public static int Finder(string a, string b)
        {
            if (a.Contains(b))
            {
                return a.IndexOf(b);
            }
            else
            {
                return -1;
            }
        }
    }
}
