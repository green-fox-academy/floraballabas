using System;

namespace GreenFoxOrganization
{
    public class Mentor : Person
    {
        private string level;

        public Mentor(string name = "Jane Doe", int age = 30, string gender = "female", string level = "intermediate")
        {
            base.name = name;
            base.age = age;
            base.gender = gender;
            this.level = level;
        }

        public override void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers.");
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm " + name + ", a " + age + " year old " + gender + " " + level + " mentor.");
        }
    }
}
