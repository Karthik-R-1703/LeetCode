using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1027
{
    // 1027. Longest Arithmetic Subsequence
    // https://leetcode.com/problems/longest-arithmetic-subsequence/
    internal class Program
    {
        public static int LongestArithSeqLength(int[] nums)
        {
            int length = 0;

            Dictionary<int, List<int>> diffs = new Dictionary<int, List<int>>();

            for (int i = nums.Length - 1; i > 0; i--)
            {
                int diff = nums[i] - nums[i - 1];
                if (diffs.ContainsKey(diff))
                {
                    diffs[diff].Add(nums[i]);
                }
                else
                {
                    foreach (KeyValuePair<int, List<int>> pair in diffs)
                    {
                        foreach (int value in pair.Value)
                        {
                            int t = value - nums[i];
                            if (diffs.ContainsKey(t))
                            {
                                diffs[t].Add(nums[i]);
                            }
                            else
                            {
                                diffs.Add(t, new List<int>() { nums[i] });
                            }
                        }
                    }

                    diffs.Add(diff, new List<int>() { nums[i] });
                }
            }

            return length;
        }

        static void Main(string[] args)
        {
            int[] nums1 = { 3, 6, 9, 12 };
            LongestArithSeqLength(nums1);

            int[] nums2 = { 9, 4, 7, 2, 10 };
            LongestArithSeqLength(nums2);

            int[] nums3 = { 20, 1, 15, 3, 10, 5, 8 };
            LongestArithSeqLength(nums3);
        }
    }
}
