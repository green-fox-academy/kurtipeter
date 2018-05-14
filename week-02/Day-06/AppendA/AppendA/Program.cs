using System;

namespace AppendA
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `animals`
            //   with the following content: `["kuty", "macsk", "cic"]`
            // - Add all elements an `"a"` at the end

            string[] animals = { "kuty", "macsk", "cic" };

            for (int i = 0; i < animals.Length; i++)
            {
                animals[i] = animals[i] + "a";
            }

            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i]);
            }

            Console.ReadLine();
        }
    }
}
