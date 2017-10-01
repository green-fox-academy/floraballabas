using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherAndStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            Student student = new Student();

            Teacher.Teach();
            Student.Question();
            Console.ReadLine();
        }
    }
}
