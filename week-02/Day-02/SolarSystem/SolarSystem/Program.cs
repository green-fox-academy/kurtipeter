using System;
using System.Collections.Generic;

namespace SolarSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune" };


            // Saturn is missing from the planetList
            // Insert it into the correct position
            // Create a method called PutSaturn() which has list parameter and returns the correct list of planets as a string.

            Console.WriteLine(PutSaturn(planetList));
            // Expected output: "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune", "Saturn"
            Console.ReadLine();
        }

        public static string PutSaturn(List<string> inputList)
        {
            inputList.Add("Saturn");

            string outputString = string.Join(",", inputList.ToArray());

            return outputString;
        }
    }
}
