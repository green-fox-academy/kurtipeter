using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    static class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the uppercase characters in a string!
            string test = "kPutyaE3Ncsksdf1IaS";
            foreach (var item in test.FindUpperCase())
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public static IEnumerable<char> FindUpperCase(this String inputS)
        {
            var output = from c in inputS
                         where char.IsUpper(c)
                         select c;
            return output;
        }
    }
}
