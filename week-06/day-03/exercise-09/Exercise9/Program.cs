using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to convert a char array to a string!
            char[] letterArray = {'c', 'i', 'c', 'a'};

            //Query syntax
            
            //Method syntax
            var toStringQueryWithLambda = String.Join("", letterArray.Select(character => character.ToString()));
            Console.WriteLine(toStringQueryWithLambda);
            var toStringQueryWithLambda2 = letterArray.Aggregate(new StringBuilder(), (a, b) => a.Append(b));
            Console.WriteLine(toStringQueryWithLambda2);

            Console.ReadLine();
        }
    }
}
