using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new[] { 3, 9, 2, 8, 6, 5 };

            var queryTest = from num2 in (from num in n select num * num)
                            where num2 > 20
                            select num2;

            foreach (var item in queryTest)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var methodTest = n.Select(num => num * num).Where(num2 => num2 > 20);

            foreach (var item in queryTest)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
