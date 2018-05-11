using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstVar = 22;
            int secondVar = 13;

            Console.WriteLine(firstVar + secondVar);
            Console.WriteLine(firstVar - secondVar);
            Console.WriteLine(firstVar * secondVar);
            Console.WriteLine(Convert.ToDouble(firstVar) / secondVar);
            Console.WriteLine(firstVar / secondVar);
            Console.WriteLine(firstVar % secondVar);
            Console.ReadLine();
        }
    }
}