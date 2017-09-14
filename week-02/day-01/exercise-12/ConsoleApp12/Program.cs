using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000

            double height = 5;
            double width = 6;
            double length = 8;

            double surfaceArea = 2 * (length * width + width * height + height * length);
            double volume = length * width * height;

            Console.WriteLine("Surface Area: "+surfaceArea);
            Console.WriteLine("Volume: "+volume);
        }
    }
}
