using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2275
{
    // 2275. Largest Combination With Bitwise AND Greater Than Zero
    // https://leetcode.com/problems/largest-combination-with-bitwise-and-greater-than-zero/description/
    internal class Program
    {
        public static int LargestCombination(int[] candidates)
        {
            Dictionary<int, int> count = new Dictionary<int, int>();
            foreach (int candidate in candidates)
            {
                char[] chars = Convert.ToString(candidate, 2).ToCharArray();
                int n = chars.Length - 1;
                for (int i = 0; i <= n; i++)
                {
                    int b = chars[n - i] - '0';
                    if (count.ContainsKey(i))
                        count[i] += b;
                    else
                        count.Add(i, b);
                }
            }

            return count.Values.Max();
        }

        static void Main(string[] args)
        {
            LargestCombination(new[] { 16, 17, 71, 62, 12, 24, 14 });
        }
    }
}
