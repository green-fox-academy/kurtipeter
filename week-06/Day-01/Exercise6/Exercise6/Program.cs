using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    static class Program
    {
        static void Main(string[] args)
        {
            string testString = "Peetiiii";
            Console.WriteLine(testString.FindFreqOfChar('e'));
            Console.WriteLine(testString.FindFreqOfChar2('i'));
            Console.ReadLine();
        }

        public static int FindFreqOfChar(this String inputString, char character)
        {
            var queryTest = inputString.ToLower().Where(k => k == character).Count();
            return queryTest;
        }

        public static int FindFreqOfChar2(this String inputString, char character)
        {
            var methodTest = (from c in inputString.ToLower()
                             where c == character
                             select c).Count();
            return methodTest;
        }
    }
}
