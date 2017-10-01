using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolStation
{
    class Station
    {
        private int gasAmount = 3000;
        
        public int GasAmount
        {
            get
            {
                return this.gasAmount;
            }
        }
        public void Refill(Car car)
        {
            this.gasAmount -= car.Capacity;
            car.GasAmount += car.Capacity;
        }
        
    }
}
