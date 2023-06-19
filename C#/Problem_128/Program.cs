using System;
using System.Collections.Generic;

namespace Problem_128
{
    // 128. Longest Consecutive Sequence
    // https://leetcode.com/problems/longest-consecutive-sequence/
    internal class Program
    {
        public static int LongestConsecutive(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            HashSet<int> numList = new HashSet<int>(nums);
            int longestStreak = 0;

            foreach (int num in numList)
            {
                if (!numList.Contains(num - 1))
                {
                    int currentNum = num;
                    int currentStreak = 1;

                    while (numList.Contains(currentNum + 1))
                    {
                        currentNum++;
                        currentStreak++;
                    }

                    longestStreak = Math.Max(longestStreak, currentStreak);
                }
            }

            return longestStreak;
        }

        static void Main(string[] args)
        {
            int[] nums = { 100, 4, 200, 1, 3, 2 };
            LongestConsecutive(nums);
        }
    }
}
