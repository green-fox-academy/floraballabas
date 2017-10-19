using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotApp
{
    public enum CarType
    {
        Trabant, 
        Lada, 
        Skoda
    }
    public enum CarColor
    {
        green,
        blue,
        red
    }

    public class Car
    {
        Random rnd = new Random();

        public CarType Type { get; }
        public CarColor Color { get; }

        public Car(CarType type, CarColor color)
        {
            this.Type = type;
            this.Color = color;
        }
    }
}
