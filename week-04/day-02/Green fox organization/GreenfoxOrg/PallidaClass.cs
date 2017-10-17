using System;
using System.Collections.Generic;

namespace GreenFoxOrganization
{
    public class PallidaClass
    {
        private string className;
        //private int students = 0;
        //private int mentors = 0;
        //  private string students;
        //  private string mentors;

        private List<Student> StudentList = new List<Student>();
        private List<Mentor> MentorList = new List<Mentor>();
        //   private List<StudentList, Mentor> PallidaClassStudentMentor = new List<Student, Mentor>;

        public PallidaClass(string className)
        {
            this.className = className;
        }

        public List<Student> AddStudent(Student student)
        {
            StudentList.Add(student);
            // students++;
            return StudentList;
        }

        public List<Mentor> AddMentor(Mentor mentor)
        {
            MentorList.Add(mentor);
            // mentors++;
            return MentorList;
        }

        public void Info()
        {
            Console.WriteLine("Pallida " + className + " class has " + StudentList.Count + " students and " +
                              MentorList.Count + " mentors.");
        }

    }
}
