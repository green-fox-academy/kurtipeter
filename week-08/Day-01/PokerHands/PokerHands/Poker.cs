using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHandsApp
{
    public class Poker
    {
        public bool CheckInputLength12(string input)
        {
            string[] temp = input.Split(' ');
            return temp.Length == 12;
        }

        public string[] MakeRaw(string input)
        {
            string[] raw = input.Split(' ');
            return raw;
        }

        public List<string> GetHandOfBlackPlayer(string input)
        {
            string[] raw = MakeRaw(input);
            List<string> output = new List<string>()
            {
                raw[1],
                raw[2],
                raw[3],
                raw[4],
                raw[5],
            };
            return output;
        }

        public List<string> GetHandOfWhitePlayer(string input)
        {
            string[] raw = MakeRaw(input);
            List<string> output = new List<string>()
            {
                raw[7],
                raw[8],
                raw[9],
                raw[10],
                raw[11],
            };
            return output;
        }

        public int GetValue(string input)
        {
            char temp = input[0];

            if (temp.ToString() == "T")
            {
                return 10;
            }
            else if (temp.ToString() == "J")
            {
                return 11;
            }
            else if (temp.ToString() == "Q")
            {
                return 12;
            }
            else if (temp.ToString() == "K")
            {
                return 13;
            }
            else if (temp.ToString() == "A")
            {
                return 14;
            }

            double output = Char.GetNumericValue(temp);
            return (int)output;
        }

        public List<int> GetHandValues(List<string> input)
        {
            List<int> output = new List<int>();
            input.ForEach(x => output.Add(GetValue(x)));
            return output;
        }
    }
}
