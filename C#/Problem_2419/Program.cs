using System;

namespace Problem_2419
{
    // 2419. Longest Subarray With Maximum Bitwise AND
    // https://leetcode.com/problems/longest-subarray-with-maximum-bitwise-and/description/
    internal class Program
    {
        public int LongestSubarray(int[] nums)
        {
            int longestLength = 0;
            int max = 0;
            int curMax = 0;
            foreach (int num in nums)
            {
                if (max < num)
                {
                    max = num;
                    longestLength = curMax = 0;
                }

                if (max == num)
                    curMax++;
                else
                    curMax = 0;

                longestLength = Math.Max(longestLength, curMax);
            }

            return longestLength;
        }

        static void Main(string[] args)
        {
        }
    }
}
