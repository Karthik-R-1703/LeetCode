using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_6939
{
    // 6939. Max Pair Sum in an Array
    // 2815. Max Pair Sum in an Array
    // https://leetcode.com/problems/max-pair-sum-in-an-array/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 51, 71, 17, 24, 42 };
            MaxSum(nums1);

            int[] nums2 = { 1, 2, 3, 4 };
            MaxSum(nums2);
        }

        public static int MaxSum(int[] nums)
        {
            Dictionary<int, List<int>> pairs = new Dictionary<int, List<int>>();
            foreach (int num in nums)
            {
                int temp = num.ToString().Max() - '0';
                if (pairs.ContainsKey(temp))
                    pairs[temp].Add(num);
                else
                    pairs[temp] = new List<int>() { num };
            }

            int max = -1;
            foreach (List<int> pair in pairs.Values)
            {
                if (pair.Count <= 1)
                    continue;

                pair.Sort((a, b) => b - a);
                max = Math.Max(max, pair[0] + pair[1]);
            }

            return max;
        }
    }
}
