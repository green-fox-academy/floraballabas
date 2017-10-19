using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var parkinglot = new ParkingLot(10);

            foreach (var car in parkinglot.listOfCars)
            {
                Console.WriteLine(car.Type+" "+car.Color);
            }

            Console.WriteLine();
            parkinglot.GetNumberOfSameType();
            parkinglot.GetNumberOfSameColor();

            Console.ReadLine();
        }
    }
}
