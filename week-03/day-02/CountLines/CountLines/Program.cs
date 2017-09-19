using System;
using System.IO;

namespace CountLines
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that takes a filename as string,
            // then returns the number of lines the file contains.
            // It should return zero if it can't open the file, and
            // should not raise any error.

            Console.WriteLine(CountTheLines());
            Console.ReadLine();
        }
        public static int CountTheLines()
        {
            string path = @"./assets/my-file.txt";
            try
            {
                string[] content = File.ReadAllLines(path);
                return content.Length;
            }
            catch (Exception)
            {
                return 0;
            }

        }
    }
}
