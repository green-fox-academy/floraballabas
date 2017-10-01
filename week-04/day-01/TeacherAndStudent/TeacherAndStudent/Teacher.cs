using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherAndStudent
{
    class Teacher
    {

        public static void Teach()
        {
            Student.Learn();
        }
        public static void Answer()
        {
            Console.WriteLine("answers");
        }
    }
}
