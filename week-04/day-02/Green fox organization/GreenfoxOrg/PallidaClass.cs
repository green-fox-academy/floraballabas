using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenfoxOrg
{
    class PallidaClass
    {
        private string className;
        private string students;
        private string mentors;
        private List<Student> studentsList = new List<Student>();
        private List<Mentor> mentorsList = new List<Mentor>();

        public PallidaClass(string className)
        {
            this.className = className;
        }
        
        public void AddStudent(Student Name)
        {
            studentsList.Add(new Student());
        }

        public void AddSMentor(Mentor Name)
        {
            mentorsList.Add(new Mentor());
        }

        public void Info()
        {
            Console.WriteLine("Pallida "+className+" class has "+studentsList.Count+" students and "+mentorsList.Count+" mentors.");
        }
    }
}
