using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotApp
{
    class ParkingLot
    {
        public List<Car> listOfCars = new List<Car>();
        Random random = new Random();

        public ParkingLot(int numberOfCars)
        {
            for (int i = 0; i < numberOfCars; i++)
            {
                listOfCars.Add(new Car((CarType)random.Next(typeof(CarType).GetEnumNames().Length),
                    (CarColor)random.Next(typeof(CarColor).GetEnumNames().Length)));
            }
        }
    }
}
