using System;
using System.IO;

namespace CopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful
            string original = "original.txt";
            string copy = "copy.txt";
            Console.WriteLine(MakeACopy(original, copy));
            Console.ReadLine();
        }

        public static bool MakeACopy(string originalPath, string copyPath)
        {
            try
            {
                string[] originalContent = File.ReadAllLines(originalPath);

                StreamWriter sw = new StreamWriter(copyPath);

                foreach (string item in originalContent)
                {
                    sw.WriteLine(item);
                }

                sw.Dispose();

                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
