using System;

namespace Comparable
{
    public class Domino : IComparable<Domino>
    {
        private readonly int[] Values;

        public Domino(int valueA, int valueB)
        {
            this.Values = new int[] { valueA, valueB };
        }

        public string GetDominoString()
        {
            return $"[{Values[0]}, {Values[1]}]";
        }

        public int CompareTo(Domino that)
        {
            if (this.Values[0] > that.Values[0]) return 1;
            if (this.Values[0] == that.Values[0]) return 0;
            return -1;
        }

        public int[] GetValues()
        {
            return Values;
        }
    }
}
