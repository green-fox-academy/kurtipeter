using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Modify this program to greet user instead of the World!
            // The program should ask for the name of the user
            string name = "";
            Console.WriteLine("Give my your name or die like a coward");
            name = Console.ReadLine();
            Console.WriteLine("Hi " + name + ", thank you");
            Console.ReadLine();
        }
    }
}