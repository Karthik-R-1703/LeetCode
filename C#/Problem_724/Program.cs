using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_724
{
    // 724. Find Pivot Index
    // https://leetcode.com/problems/find-pivot-index/
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums;

            nums = new List<int>() { 1, 7, 3, 6, 5, 6 };
            PivotIndex(nums.ToArray());

            nums = new List<int>() { 1, 2, 3 };
            PivotIndex(nums.ToArray());

            nums = new List<int>() { 2, 1, -1 };
            PivotIndex(nums.ToArray());
        }

        public static int PivotIndex(int[] nums)
        {
            int lpi = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                int[] l_nums = new int[i];
                Array.Copy(nums, 0, l_nums, 0, i);

                int r = nums.Length - 1 - i;
                int[] r_nums = new int[r];
                Array.Copy(nums, i + 1, r_nums, 0, r);

                if (l_nums.Sum() == r_nums.Sum())
                {
                    lpi = i;
                    break;
                }
            }

            return lpi;
        }
    }
}
