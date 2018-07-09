using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Controllers
{
    public class Service
    {
        public int Sumer(int until)
        {
            int output = 0;
            for (int i = 0; i < until+1; i++)
            {
                output += i;
            }
            return output;
        }

        public int Factorer(int until)
        {
            int output = 1;
            for (int i = 1; i < until+1; i++)
            {
                output *= i;
            }
            return output;
        }

        public int ArraySum(int[] input)
        {
            int output = 0;
            for (int i = 0; i < input.Length; i++)
            {
                output += input[i];
            }
            return output;
        }

        public int ArrayMultiply(int[] input)
        {
            int output = 1;
            for (int i = 0; i < input.Length; i++)
            {
                output *= input[i];
            }
            return output;
        }
        
        public int[] ArrayDoubler(int[] input)
        {
            int[] output = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                output[i] = input[i] * 2;
            }
            return output;
        }
    }
}
