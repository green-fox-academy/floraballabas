using System;
using System.Text;
using System.Collections.Generic;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Saturn is missing from the planetList
            // Insert it into the correct position

            var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus",
            "Neptune" };
            planetList.Insert(5, "Saturn");
            foreach (var planet in planetList)
            {
                Console.WriteLine(planet);
            }
            Console.ReadLine();
        }
    }
}
