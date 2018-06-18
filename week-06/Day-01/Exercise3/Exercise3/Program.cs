using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var queryTest = from num in n
                            where num % 2 == 0
                            select num * num;

            foreach (var item in queryTest)
            {
                Console.WriteLine(item);
            }

            var methodTest = n.Where(num => num % 2 == 0).Select(num => num * num);

            foreach (var item in queryTest)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
