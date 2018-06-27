using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anagramm.Anagram
{
    public interface IAnagramm
    {
        void MakeAnagramm(string input);
        bool GetResult();
    }
}
