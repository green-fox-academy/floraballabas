using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CopyFileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful
            CopyFile();
            Console.ReadLine();
        }

        private static void CopyFile()
        {
            string path = "../../original.txt";
            string destination = "copied.txt";

            File.Copy(path, destination);

        }
    }
}
