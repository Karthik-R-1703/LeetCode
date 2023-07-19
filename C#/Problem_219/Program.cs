using System;
using System.Collections.Generic;

namespace Problem_219
{
    // 219. Contains Duplicate II
    // https://leetcode.com/problems/contains-duplicate-ii/
    internal class Program
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, List<int>> d_nums = new Dictionary<int, List<int>>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (d_nums.ContainsKey(nums[i]))
                {
                    d_nums[nums[i]].Add(i);
                }
                else
                {
                    d_nums.Add(nums[i], new List<int>() { i });
                }
            }

            foreach (KeyValuePair<int, List<int>> keyValuePair in d_nums)
            {
                for (int x = 0; x < keyValuePair.Value.Count - 1; x++)
                {
                    int i = keyValuePair.Value[x];
                    int j = keyValuePair.Value[x + 1];
                    if (Math.Abs(i - j) <= k)
                        return true;
                }
            }

            return false;
        }

        static void Main(string[] args)
        {
        }
    }
}
