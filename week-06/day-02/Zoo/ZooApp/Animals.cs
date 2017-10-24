using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    public abstract class Animals
    {
        protected string name;
        protected int age;
        protected string gender;
        protected string habitat;

        public Animals(string name)
        {
            this.name = name;
        }
        public string GetName
        {
           get
            {
                return name;
            }
        }

        public abstract void WantChild();

        public void Greet()
        {
            Console.WriteLine($"Hello {name}!");
        }

    }
}
