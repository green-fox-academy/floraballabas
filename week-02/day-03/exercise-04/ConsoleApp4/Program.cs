using System;
using System.Text;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add "My todo:" to the beginning of the todoText
            // Add " - Download games" to the end of the todoText
            // Add " - Diablo" to the end of the todoText but with indention

            // Expected output:

            // My todo:
            //  - Buy milk
            //  - Download games
            //      - Diablo
            string todoText = "My todo:";
            todoText = todoText.Insert(todoText.Length, "\n - Download games");
            todoText = todoText.Insert(todoText.Length, "\n \t - Diablo");


            Console.WriteLine(todoText);
            Console.ReadLine();
        }
    }
}
