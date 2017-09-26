using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenfoxOrg
{
    class Person
    {
        public string name;
        public int age;
        public string gender;

        public Person(string name = "Jane Doe", int age = 30, string gender = "female")
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public void Introduce()
        {
            Console.WriteLine("Hello, I am "+name+" a "+age+" year old "+gender);
        }
        public void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }
    }
}
