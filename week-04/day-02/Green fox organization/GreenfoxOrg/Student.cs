using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenfoxOrg
{
    class Student : Person
    {
        private string previousOrganization = "TCS";
        private int skippedDays = 0;
        //Student(): sets name to Jane Doe, age to 30, gender to female, 
        //previousOrganization to The School of Life, skippedDays to 0
        public Student(string name = "Jane Doe", int age = 30, string gender = "female",
            string previousOrganization = "The School of Life", int skippedDays = 0)
        {
            base.name = name;
            base.age = age;
            base.gender = gender;
            this.previousOrganization = previousOrganization;
            this.skippedDays = skippedDays;
        }

        public new void GetGoal()
        {
            Console.WriteLine("My goal is to be a junior software developer.");
        }

        public new void Introduce()
        {
            Console.WriteLine("Hi, I'm " +name +", a "+age+" year old "+gender+" from "+previousOrganization+" who skipped "+skippedDays+" days from the course already.");
        }
        public int SkipDays(int numberOfDays)
        {
            return skippedDays += numberOfDays++;
        }

    }
}
