using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS", "AskjdfnsdnfI" };
            IEnumerable<string> solution = FindCity(cities);
            foreach (var sol in solution)
            {
                Console.WriteLine(sol);
            }
            Console.ReadLine();
        }

        static public IEnumerable<string> FindCity(string[] cities)
        {
            var output = from city in cities
                         where city[0] == 'A' && city[city.Length - 1] == 'I'
                         select city;
            return output;
        }
    }
}
