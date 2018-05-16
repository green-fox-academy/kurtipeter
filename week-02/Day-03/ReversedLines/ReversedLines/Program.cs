using System;
using System.IO;

namespace ReversedLines
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RevLines("needreversing.txt"));
            Console.ReadLine();
        }

        public static string RevLines(string path)
        {
            string[] content = File.ReadAllLines(path);
            string revCont = "";

            for (int i = 0; i < content.Length; i++)
            {
                for (int j = content[i].Length - 1; j >= 0; j --)
                {
                    revCont += content[i][j];
                }
                revCont += "\n";
            }

            StreamWriter sw = new StreamWriter("reversed.txt");
            sw.WriteLine(revCont);
            sw.Dispose();

            return revCont;
        }
    }
}
