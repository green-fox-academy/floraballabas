using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherAndStudent
{
    class Student
    {
        public static void Learn()
        {
            Console.WriteLine("learning");
        }
        public static void Question()
        {
            Console.WriteLine("question");
            Teacher.Answer();
        }
    }
}
