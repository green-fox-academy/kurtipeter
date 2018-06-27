using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anagramm.Anagram
{
    public class Anagrammer : IAnagramm
    {
        private string anagramm;
        private bool isAnagram;

        public bool GetResult()
        {
            return isAnagram;
        }

        public void MakeAnagramm(string input)
        {
            char[] temp = input.ToCharArray();
            Array.Reverse(temp);
            anagramm = string.Join("", temp);
            isAnagram = input.ToLower().Equals(anagramm.ToLower());
        }
    }
}
