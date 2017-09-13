using System;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";

            // When saving this quote a disk error has occured. Please fix it.
            // Add "always takes longer than" to the StringBuilder (quote) between the words "It" and "you"
            // Using pieces of the quote variable (instead of just redefining the string)
            StringBuilder quote2 = new StringBuilder(quote);
            quote2 = quote2.Insert(20, " always takes longer than");

            Console.WriteLine(quote2);
            Console.ReadLine();
        }
    }
}
