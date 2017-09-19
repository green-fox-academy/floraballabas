using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WriteMultipleLines
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes 3 parameters: a path, a word and a number,
            // than it should write to a file.
            // The path parameter should be a string, that describes the location of the file.
            // The word parameter should be a string, that will be written to the file as lines
            // The number paramter should describe how many lines the file should have.
            // So if the word is "apple" and the number is 5, than it should write 5 lines
            // to the file and each line should be "apple"
            // The function should not raise any error if it could not write the file.
            WriteLines();
            Console.ReadLine();
        }
        public static void WriteLines()
        {
            Console.WriteLine("Please tell me where is the text file located");
            string path = Console.ReadLine();
            Console.WriteLine("What should I write in the text file?");
            string word = Console.ReadLine();
            Console.WriteLine("How many lines should I fill with the previous content?");
            int number = int.Parse(Console.ReadLine());

            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int i = 0; i < number; i++)
                {
                    writer.WriteLine(word);
                }
               
            }
        }
    }
}
