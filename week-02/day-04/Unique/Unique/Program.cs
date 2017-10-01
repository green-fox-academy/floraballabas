using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unique
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a function that takes a list of numbers as a parameter
            //Returns a list of numbers where every number in the list occurs only once
            List<int> listWithDuplicats = new List<int> { 1, 11, 34, 11, 52, 61, 1, 34 };
            DeDuplicate(listWithDuplicats);
            Console.ReadLine();
        }

        private static void DeDuplicate(List<int> listWithDuplicats)
        {
            listWithDuplicats.Sort();
            int index = 0;
            while (index < listWithDuplicats.Count - 1)
            {
                if (listWithDuplicats[index] == listWithDuplicats[index + 1])
                    listWithDuplicats.RemoveAt(index);
                else
                    index++;
            }
            foreach (var list in listWithDuplicats)
            {
                Console.WriteLine(list);
            }
        }
    }
}
