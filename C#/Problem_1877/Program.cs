using System;

namespace Problem_1877
{
    // 1877. Minimize Maximum Pair Sum in Array
    // https://leetcode.com/problems/minimize-maximum-pair-sum-in-array/description/
    internal class Program
    {
        static void Main(string[] args)
        {
            MinPairSum(new int[] { 3, 5, 2, 3 });
            MinPairSum(new int[] { 3, 5, 4, 2, 4, 6 });
            MinPairSum(new int[] { 4, 1, 5, 1, 2, 5, 1, 5, 5, 4 });
        }

        public static int MinPairSum(int[] nums)
        {
            Array.Sort(nums);
            int sum = nums[0] + nums[nums.Length - 1];
            for (int i = 1; i < nums.Length / 2; i++)
            {
                sum = Math.Max(sum, nums[i] + nums[nums.Length - 1 - i]);
            }

            return sum;
        }
    }
}
