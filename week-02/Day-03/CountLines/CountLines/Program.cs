using System;
using System.IO;

namespace CountLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"my-file.txt";
            try
            {
                string[] content = File.ReadAllLines(path);

                int lineCount = 0;

                foreach (string item in content)
                {
                    lineCount++;
                }

                Console.WriteLine(lineCount);
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to read file: my-file.txt!");
            }

            Console.ReadLine();
        }
    }
}
