using System;
using System.Collections.Generic;
using System.Text;

namespace Comparable
{
    public class Domino : IComparable<Domino>
    {
        private readonly int[] Values;

        public Domino(int valueA, int valueB)
        {
            this.Values = new int[] { valueA, valueB };
        }

        public int CompareTo(Domino domino)
        {
            return GetValues()[0].CompareTo(domino.GetValues()[0]);
        }

        public override string ToString()
        {
            return string.Format("[{0}, {1}]",Values[0],Values[1]);
        }

        public int[] GetValues()
        {
            return Values;
        }
    }
}