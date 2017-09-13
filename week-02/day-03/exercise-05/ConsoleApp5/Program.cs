using System;

namespace ConsoleApp5
{
    class Program
    {
        public static void Reverse()
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";
            char[] reversedarray = reversed.ToCharArray();
            Array.Reverse(reversedarray);
            string output = new string(reversedarray);
            Console.WriteLine(output);
        }

        static void Main(string[] args)
        {

            // Create a function that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!
            Reverse();
            Console.ReadLine();
        }
    }
}
