using System;

namespace Problem_1051
{
    // 1051. Height Checker
    // https://leetcode.com/problems/height-checker/
    internal class Program
    {
        public static int HeightChecker(int[] heights)
        {
            int[] expected = (int[])heights.Clone();
            int notMatch = 0;

            Array.Sort(expected);

            for (int i = 0; i < heights.Length; i++)
            {
                if (heights[i] != expected[i])
                {
                    notMatch++;
                }
            }

            return notMatch;
        }

        static void Main(string[] args)
        {
        }
    }
}
