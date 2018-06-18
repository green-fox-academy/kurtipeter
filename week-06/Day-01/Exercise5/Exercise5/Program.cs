using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var queryTest = from num in n
                            group num by num into g
                            select new { Count = g.Count(), Key = g.Key };

            foreach (var item in queryTest)
            {
                Console.WriteLine( item.Key + " " + item.Count );
            }

            Console.WriteLine();

            var methodTest = n.GroupBy(num => num);

            foreach (var item in methodTest)
            {
                Console.WriteLine(item.Key + " " + item.Count());
            }

            Console.ReadLine();
        }
    }
}
