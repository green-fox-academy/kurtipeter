using System;
using System.Collections.Generic;
using System.Text;

namespace TeacherStudent
{
    class Student
    {
        public void Learn()
        {
            Console.Write("the student is learning");
        }

        public void Question(Teacher teacher)
        {
            teacher.Answer();
        }
    }
}
