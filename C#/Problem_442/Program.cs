using System;
using System.Collections.Generic;

namespace Problem_442
{
    // 442. Find All Duplicates in an Array
    // https://leetcode.com/problems/find-all-duplicates-in-an-array/description/
    internal class Program
    {
        public static IList<int> FindDuplicates(int[] nums)
        {
            List<int> result = new List<int>();
            Array.Sort(nums);
            int prevVal = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == prevVal)
                    result.Add(nums[i]);
                else
                    prevVal = nums[i];
            }

            return result;
        }

        static void Main(string[] args)
        {
        }
    }
}
