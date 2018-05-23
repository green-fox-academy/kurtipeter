using System;
using System.IO;
using System.Text;

namespace ReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RevOrder("needOrderReversing.txt"));
            Console.ReadLine();
        }

        public static string RevOrder(string path)
        {
            string[] content = File.ReadAllLines(path);
            string revOrderCont = "";

            for (int j = content.Length - 1; j >= 0; j--)
            {
                revOrderCont += content[j];
                if (j != 0)
                {
                    revOrderCont += "\n";
                }              
            }

            StreamWriter sw = new StreamWriter("orderReversed.txt");
            sw.WriteLine(revOrderCont);
            sw.Dispose();

            return revOrderCont;
        }
    }
}
