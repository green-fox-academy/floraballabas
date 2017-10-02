using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmApp
{
    class Animal
    {
        private int hunger;
        private int thirst;
        private string breed;

        public Animal(string breed = "pig", int hunger = 50, int thirst = 50)
        {
            this.hunger = hunger;
            this.thirst = thirst;
            this.breed = breed;
        }

        public void Eat()
        {
            hunger--;
        }
        public void Drink()
        {
            thirst--;
        }
        public void Play()
        {
            thirst++;
            hunger++;
        }
        public int Hunger
        {
            get
            {
                return hunger;
            }
        }
        public int Thirst
        {
            get
            {
                return thirst;
            }
        }
        public string Breed
        {
            get
            {
                return breed;
            }
        }
    }
}