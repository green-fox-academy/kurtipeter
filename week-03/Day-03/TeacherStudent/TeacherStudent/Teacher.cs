
using System;
using System.Collections.Generic;
using System.Text;

namespace TeacherStudent
{
    class Teacher
    {
        public void Answer()
        {
            Console.Write("the teacher is answering");
        }

        public void Teach(Student student)
        {
            student.Learn();
        }
    }
}
