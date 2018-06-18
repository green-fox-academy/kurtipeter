using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] test = new char[] { 'k', 'u', 't', 'y', 'a' };

            string convertToString = new string(test);

            string converter = string.Join("", test.Select(s => s));

            Console.WriteLine(converter);
            Console.WriteLine(convertToString);
            Console.ReadLine();

        }
    }
}
