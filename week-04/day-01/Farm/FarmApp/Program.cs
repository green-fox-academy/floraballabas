using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal("horse", 80, 20);
            Animal animal2 = new Animal("dog", 70, 20);
            Animal animal3 = new Animal("chicken", 10, 20);
            Animal animal4 = new Animal("cow", 95, 20);
            Animal animal5 = new Animal("sheep", 30, 20);
            Animal animal6 = new Animal("pig", 40, 20);

            Farm farm = new Farm();
            farm.Slot = 8;

            farm.AnimalList.Add(animal1);
            farm.AnimalList.Add(animal2);
            farm.AnimalList.Add(animal3);
            farm.AnimalList.Add(animal4);
            farm.AnimalList.Add(animal5);
            farm.AnimalList.Add(animal6);

            farm.Breed(farm.AnimalList);
            farm.Slaughter(farm.AnimalList);
            farm.Print(farm.AnimalList);
            Console.ReadLine();
        }
    }
}
