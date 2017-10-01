using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a function that takes a number and a list of numbers as a parameter
            //Returns the indeces of the numbers in the list where the first number is part of
            //Returns an empty list if the number is not part any of the numbers in the list
            List<int> list = new List<int> {1, 11, 34, 52, 61};
            int num = 1;
            foreach (var item in Finder(list, num))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        public static List<int> Finder(List<int> list, int num)
        {
            List<int> output = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ToString().Contains(num.ToString()))
                {
                    output.Add(i);
                }
            }
            return output;
        }
    }
}
