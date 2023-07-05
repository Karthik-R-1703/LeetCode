using System;

namespace Problem_561
{
    // 561. Array Partition
    // https://leetcode.com/problems/array-partition/
    internal class Program
    {
        public static int ArrayPairSum(int[] nums)
        {
            int sum = 0;
            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i += 2)
            {
                sum += nums[i];
            }

            return sum;
        }

        static void Main(string[] args)
        {
            int[] nums1 = { 1, 4, 3, 2 };
            ArrayPairSum(nums1);

            int[] nums2 = { 6, 2, 6, 5, 1, 2 };
            ArrayPairSum(nums2);
        }
    }
}
