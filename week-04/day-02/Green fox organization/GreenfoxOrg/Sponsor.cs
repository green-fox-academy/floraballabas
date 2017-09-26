using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenfoxOrg
{
    class Sponsor : Person
    {
        private string company;
        private int hiredStudents;

        public Sponsor(string name = "Jane Doe", int age = 30, string gender = "female", string company = "Google", int hiredStudents = 0)
        {
            base.name = name;
            base.age = age;
            base.gender = gender;
            this.company = company;
            this.hiredStudents = hiredStudents;
        }

        public new void Introduce()
        {
            Console.WriteLine("Hi, I'm "+name+", a "+age+" year old "+gender+" who represents "+company+" and hired "+hiredStudents+" students so far.");
        }
        public int Hired()
        {
            return hiredStudents = hiredStudents++;
        }
        public new void GetGoal()
        {
            Console.WriteLine("My goal is : Hire brilliant junior software developers.");
        }
    }
}
