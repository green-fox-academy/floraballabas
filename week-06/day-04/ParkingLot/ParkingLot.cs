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

        public void GetNumberOfSameType()
        {
            var ladaQuery = from lada in listOfCars
                            where lada.Type == CarType.Lada
                            select lada;

            var trabantQuery = from trabant in listOfCars
                            where trabant.Type == CarType.Trabant
                            select trabant;

            var skodaQuery = from skoda in listOfCars
                            where skoda.Type == CarType.Skoda
                            select skoda;
            Console.WriteLine("Number of ladas: {0} \nNumber of trabants: {1} \nNumber of skodas: {2}", 
                ladaQuery.Count(),trabantQuery.Count(), skodaQuery.Count());
        }

        public void GetNumberOfSameColor()
        {
            var greenQuery = from color in listOfCars
                             where color.Color == CarColor.green
                             select color;

            var blueQuery = from color in listOfCars
                            where color.Color == CarColor.blue
                            select color;

            var redQuery = from color in listOfCars
                           where color.Color == CarColor.red
                           select color;

            Console.WriteLine("Number of green cars: {0} \nNumber of blue cars: {1} \nNumber of red cars: {2}",
                greenQuery.Count(), blueQuery.Count(), redQuery.Count());
        }
        public void GetMostFrequentCar()
        {
            var frequencyOfCars = from car in listOfCars
                                  group car by car.Type into uniqueCars
                                  orderby uniqueCars.Count() descending
                                  select new { uniqueCars.Key, Count = uniqueCars.Count() };
            var mostFrequent = frequencyOfCars.FirstOrDefault();

            Console.WriteLine("The most common car in the parkinglot is: {0}", mostFrequent.Key);
        }
    }
}
