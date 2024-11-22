using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_1072
{
    // 1072. Flip Columns For Maximum Number of Equal Rows
    // https://leetcode.com/problems/flip-columns-for-maximum-number-of-equal-rows/description/
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static int MaxEqualRowsAfterFlips(int[][] matrix)
        {
            Dictionary<string, int> patterns = new Dictionary<string, int>();
            for (int i = 0; i < matrix.Length; i++)
            {
                StringBuilder pattern = new StringBuilder();
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][0] == matrix[i][j])
                        pattern.Append("T");
                    else
                        pattern.Append("F");
                }

                if (patterns.ContainsKey(pattern.ToString()))
                    patterns[pattern.ToString()]++;
                else
                    patterns.Add(pattern.ToString(), 1);
            }

            return patterns.Values.Max();
        }
    }
}