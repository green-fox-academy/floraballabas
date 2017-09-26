using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenfoxOrg
{
    class Mentor : Person
    {
        private string level;
        public Mentor(string name = "Jane Doe", int age = 30, string gender = "female", string level = "intermediate")
        {
            base.name = name;
            base.age = age;
            base.gender = gender;
            this.level = level;
        }

        public new void GetGoal()
        {
            Console.WriteLine("My goal is: Educate brilliant junior software developers.");
        }
        public new void Introduce()
        {
            Console.WriteLine("Hi, I'm "+name+", a "+age+" year old "+gender+" "+level+" mentor.");
        }
    }
}
