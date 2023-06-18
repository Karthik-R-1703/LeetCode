using System;
using System.Linq;

namespace Problem_4
{
    // 4. Median of Two Sorted Arrays
    // https://leetcode.com/problems/median-of-two-sorted-arrays/
    internal class Program
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double median = 0;
            int[] nums = nums1.Concat(nums2).ToArray();
            Array.Sort(nums);

            if (nums.Length % 2 == 0)
            {
                double mid1 = nums[(nums.Length - 1) / 2];
                double mid2 = nums[nums.Length / 2];
                median = (mid1 + mid2) / 2;
            }
            else
            {
                median = nums[nums.Length / 2];
            }

            return median;
        }

        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2 };
            int[] nums2 = { 3, 4 };
            double median = FindMedianSortedArrays(nums1, nums2);
        }
    }
}
