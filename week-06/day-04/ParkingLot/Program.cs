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
            var parkinglot = new ParkingLot(250);

            parkinglot.GetNumberOfSameType();
            parkinglot.GetNumberOfSameColor();
            parkinglot.GetMostFrequentCar();

            Console.ReadLine();
        }
    }
}
