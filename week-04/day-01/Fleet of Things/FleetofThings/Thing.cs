using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOfThings
{
    public class Thing
    {
        private string Name;
        private bool Completed;

        public Thing(string name)
        {
            this.Name = name;
            if (name == "Stand up" || name == "Eat lunch")
            {
                Complete();
                Console.WriteLine("[X] "+ this.Name);
            }
            else
            {
                Completed = false;
                Console.WriteLine("[ ] "+this.Name);
            }
        }

        public void Complete()
        {
            this.Completed = true;
        }
    }
}
