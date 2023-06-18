using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1
{
    // 1. Two Sum
    // https://leetcode.com/problems/two-sum/
    internal class Program
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            List<int> pos = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int num1 = target - nums[i];
                if (nums.Contains(num1) && Array.IndexOf(nums, num1) != i)
                {
                    pos.Add(i);
                    pos.Add(Array.IndexOf(nums, num1));
                    break;
                }
            }

            return pos.ToArray();
        }

        static void Main(string[] args)
        {
            int[] numbers = { 3, 2, 4 };
            TwoSum(numbers, 6);
        }
    }
}
