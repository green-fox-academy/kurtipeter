using System;

namespace TeacherStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Teacher teacher1 = new Teacher();

            Console.Write("The student is asking a question and the ");
            student1.Question(teacher1);

            Console.WriteLine();

            Console.Write("The teacher is teaching and ");
            teacher1.Teach(student1);
            Console.ReadLine();
        }
    }
}
