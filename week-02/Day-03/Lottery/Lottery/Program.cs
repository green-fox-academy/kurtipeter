using System;
using System.Collections.Generic;
using System.IO;

namespace Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            MostCommLotteryNumb(LotteryNumberOccurence(ReadInData()));
            Console.ReadLine();
        }

        public static List<string[]> ReadInData()
        {
            try
            {
                StreamReader sr = new StreamReader("rawdata.txt");

                List<string[]> dataGrid = new List<string[]>();

                string line = "";

                while (line != null)
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {
                    dataGrid.Add(line.Split(';'));
                    }
                }

                return dataGrid;
            }
            
            catch (Exception e)
            {
                List<string[]> emptyList = new List<string[]>();
                Console.WriteLine("Somegthin went wrong with the reading:");
                Console.WriteLine(e.Message);
                Console.WriteLine("Returning an empty list :(");
                return emptyList;
            }
        }

        public static Dictionary<string, int> LotteryNumberOccurence(List<string[]> data)
        {
            Dictionary<string, int> numberCounter = new Dictionary<string, int>();

            for (int i = 0; i < data.Count; i++)
            {
                for (int j = data[i].Length - 5; j < data[i].Length; j++)
                {
                    if (!numberCounter.ContainsKey(data[i][j]))
                    {
                        numberCounter.Add(data[i][j], 1);
                    }
                    else
                    {
                        numberCounter[data[i][j]]++;
                    }
                }
            }
            return numberCounter;
        }

        /*
        public static void MostCommLotteryNumb(Dictionary<string, int> data)
        {
            foreach (KeyValuePair<string, int> number in data.OrderBy(key => key.Value));
            //self-note: try to find a non linq solution
        } */

        public static void MostCommLotteryNumb2(Dictionary<string, int> data)
        {
            foreach (KeyValuePair<string, int> itemToCompare in data)
            {
                foreach (KeyValuePair<string, int> restOfTheItem in data)
                {
                    if (itemToCompare. )
                    {

                    }
                }
            }
        }
    }
}
