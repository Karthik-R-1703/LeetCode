using System.Collections.Generic;

namespace Problem_119
{
    // 119. Pascal's Triangle II
    // https://leetcode.com/problems/pascals-triangle-ii/
    internal class Program
    {
        public IList<int> GetRow(int rowIndex)
        {
            List<int> Pascals_Triangle = new List<int>();

            if (rowIndex == 0)
            {
                Pascals_Triangle = new List<int>() { 1 };
                return Pascals_Triangle;
            }

            Pascals_Triangle = new List<int>() { 1, 1 };
            if (rowIndex == 1)
            {
                return Pascals_Triangle;
            }

            for (int i = 2; i <= rowIndex; i++)
            {
                List<int> prev_row = Pascals_Triangle;
                List<int> cur_row = new List<int>
                {
                    1
                };

                for (int j = 0; j < prev_row.Count - 1; j++)
                {
                    cur_row.Add(prev_row[j] + prev_row[j + 1]);
                }

                cur_row.Add(1);
                Pascals_Triangle = cur_row;
            }

            return Pascals_Triangle;
        }

        static void Main(string[] args)
        {
        }
    }
}
