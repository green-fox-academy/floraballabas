using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the strings which starts with A and ends with I in the following array:

            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            //Query syntax
            var cityQuery = from city in cities
                            where city.StartsWith("A") && city.EndsWith("I")
                            select city;

            foreach (var city in cityQuery)
            {
                Console.WriteLine(city);
            }

            Console.WriteLine();

            //Method syntax
            var cityQueryWithLambda = cities.Where(city => city.StartsWith("A") && city.EndsWith("I")).Select(city => city);

            foreach (var city in cityQueryWithLambda)
            {
                Console.WriteLine(city);
            }

            Console.ReadLine();
        }
    }
}
