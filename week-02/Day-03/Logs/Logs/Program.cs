using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read all data from 'log.txt'.
            // Each line represents a log message from a web server
            // Write a function that returns an array with the unique IP adresses.
            // Write a function that returns the GET / POST request ratio.
            foreach (string item in uniqueIPs("logs.txt"))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(GetPostRatio("logs.txt"));
            Console.ReadLine();
        }

        public static List<string> uniqueIPs(string path)
        {
            string[] content = File.ReadAllLines(path);

            for (int i = 0; i < content.Length; i++)
            {
                content[i] = content[i].Substring(26, 11);
            }
            List<string> outputList = new List<string>();

            for (int i = 0; i < content.Length; i++)
            {
                if (!outputList.Contains(content[i]))
                {
                    outputList.Add(content[i]);
                }
            }
            return outputList;
        }

        public static string GetPostRatio(string path)
        {
            string[] content = File.ReadAllLines(path);

            double getCount = 0.0;
            double postCount = 0.0;

            for (int i = 0; i < content.Length; i++)
            {
                if (content[i].ToString().IndexOf("GET") >= 0)
                {
                    getCount++;
                }
                else
                {
                    postCount++;
                }
            }
            getCount = getCount / content.Length * 100;
            postCount = postCount / content.Length * 100;

            string output = string.Format("GET ratio: {0}\nPOST ratio: {1}", getCount, postCount);
            return output;
        }
    }
}
