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
            todoText = todoText.Insert(8, "\n - Download games");
            string indent = "   ";
            todoText = todoText.Insert(26, "\n"+indent+" - Diablo");


            Console.WriteLine(todoText);
            Console.ReadLine();
        }
    }
}
