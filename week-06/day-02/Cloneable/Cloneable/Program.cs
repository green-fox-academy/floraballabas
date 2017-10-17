using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFoxOrganization
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            Student john = new Student("John Doe", 20, "male", "BME");
            john.Introduce();
            Student johnTheClone = (Student)john.Clone();
            johnTheClone.Introduce();
            Console.ReadLine();
        }
    }
}
