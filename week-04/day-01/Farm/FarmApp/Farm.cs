using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmApp
{
    class Farm
    {
        private int slots;
        private List<Animal> animalList = new List<Animal>();

        public int Slot
        {
            get
            {
                return slots;
            }
            set
            {
                slots = value;
            }
        }
        public List<Animal> AnimalList
        {
            get
            {
                return animalList;
            }
            set
            {
                animalList = value;
            }
        }
        public List<Animal> Breed(List<Animal> animalList)
        {
            if (slots > animalList.Count)
            {
                Animal newAnimal = new Animal();
                animalList.Add(newAnimal);
            }
            return animalList;
        }
        public List<Animal> Slaughter(List<Animal> animalList)
        {
            int hunger = 100;
            int lessHungryIndex = 0;
            for (int i = 0; i < animalList.Count; i++)
            {
                if (animalList[i].Hunger < hunger)
                {
                    hunger = animalList[i].Hunger;
                    lessHungryIndex = i;
                }
            }
            animalList.RemoveAt(lessHungryIndex);
            return animalList;
        }
        public void Print(List<Animal> animalList)
        {
            foreach (var animal in animalList)
            {
                Console.WriteLine("The animal type is: " + animal.Breed + " , thirst value: " + animal.Thirst + ", hunger value: " + animal.Hunger);
            }
        }

    }
}
