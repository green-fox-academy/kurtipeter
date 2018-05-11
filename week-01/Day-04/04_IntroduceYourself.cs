using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John Doe";
            int age = 31;
            double height = 1.87;

            Console.WriteLine("Your name: {0}", name);
            Console.WriteLine("Your age: {0}", age);
            Console.WriteLine("Your height: {0}", height);
            Console.ReadLine();
        }
    }
}