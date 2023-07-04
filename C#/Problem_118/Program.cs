using System.Collections.Generic;

namespace Problem_118
{
    // 118. Pascal's Triangle
    // https://leetcode.com/problems/pascals-triangle/
    internal class Program
    {
        public static IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> Pascals_Triangle = new List<IList<int>>();

            if (numRows > 0)
            {
                List<int> top = new List<int>() { 1 };
                Pascals_Triangle.Add(top);
            }
            else
                return Pascals_Triangle;

            if (numRows > 1)
            {
                List<int> top_2 = new List<int>() { 1, 1 };
                Pascals_Triangle.Add(top_2);
            }
            else
                return Pascals_Triangle;

            for (int i = 3; i <= numRows; i++)
            {
                List<int> prev_row = (List<int>)Pascals_Triangle[Pascals_Triangle.Count - 1];
                List<int> cur_row = new List<int>
                {
                    1
                };

                for (int j = 0; j < prev_row.Count - 1; j++)
                {
                    cur_row.Add(prev_row[j] + prev_row[j + 1]);
                }

                cur_row.Add(1);
                Pascals_Triangle.Add(cur_row);
            }

            return Pascals_Triangle;
        }

        static void Main(string[] args)
        {
            Generate(5);
            Generate(1);
        }
    }
}
