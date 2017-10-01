using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTask
{
    class Animal
    {
        private int hunger;
        private int thirst;

        public Animal(int hunger = 50, int thirst = 50)
        {
            this.hunger = hunger;
            this.thirst = thirst;
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
            thirst ++;
            hunger ++;
        }
        public int GetHunger()
        {
            return hunger;
        }
        public int GetThirst()
        {
            return thirst;
        }
    }
}
