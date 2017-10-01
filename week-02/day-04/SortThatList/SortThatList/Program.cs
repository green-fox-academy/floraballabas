using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortThatList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 34, 12, 24, 9, 5 };
            //Create a function that takes a list of numbers as parameter
            //Returns a list where the elements are sorted in ascending numerical order
            //Make a second boolean parameter, if it's true sort that list descending
            Sorting(list, true);
            Console.ReadLine();
        }
        public static List<int> Sorting(List<int> listed, bool a)
        {
            if (a == false)
            {
                listed.Sort();
                foreach (var item in listed)
                {
                    Console.Write(item + ", ");
                }
            }
            else
            {
                listed.Sort();
                listed.Reverse();
                foreach (var item in listed)
                {
                    Console.Write(item + ", ");
                }
            }
            return listed;
        }
    }
}
