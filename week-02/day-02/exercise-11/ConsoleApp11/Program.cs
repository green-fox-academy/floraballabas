using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            //- Create an array variable named `t`
            //  with the following content: `[1, 2, 3, 4, 5]`
            int[] t = {1, 2, 3, 4, 5};
            //- Increment the third element
            for (int i = 1; i < 2; i++)
            {
                t[3] += i + 1;
            }
            //- Print the third element
            Console.WriteLine(t[3]);
            Console.ReadLine();
        }
    }
}
