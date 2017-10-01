using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolStation
{
    class Car
    {
        private int gasAmount;
        private int capacity;

        public Car()
        {
            this.gasAmount = 0;
            this.capacity = 100;
        }
        public int GasAmount
        {
            get
            {
                return this.gasAmount;
            }
            set
            {
                this.gasAmount = value;
            }
        }
        public int Capacity
        {
            get
            {
                return this.capacity;
            }
        }
    }
}
