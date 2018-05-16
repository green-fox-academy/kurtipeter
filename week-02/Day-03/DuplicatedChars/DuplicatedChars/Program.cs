using System;
using System.Collections.Generic;
using System.IO;

namespace DuplicatedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DelDupChars("duplicated-chars.txt"));
            Console.ReadLine();
        }

        public static string DelDupChars(string path)
        {
            string[] content = File.ReadAllLines(path);
            string croppedCont = "";

            for (int i = 0; i < content.Length; i ++)
            {
                for (int j = 0; j < content[i].Length; j += 2)
                {
                    croppedCont += content[i][j];
                }
                croppedCont += "\n";
            }

            StreamWriter sw = new StreamWriter("croppedTXT.txt");
            sw.WriteLine(croppedCont);
            sw.Dispose();

            return croppedCont;
        }
    }
}
