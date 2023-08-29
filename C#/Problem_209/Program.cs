using System;

namespace Problem_209
{
    // 209. Minimum Size Subarray Sum
    // https://leetcode.com/problems/minimum-size-subarray-sum/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 2, 3, 1, 2, 4, 3 };
            MinSubArrayLen(7, nums1);

            int[] nums2 = { 1, 4, 4 };
            MinSubArrayLen(4, nums2);

            int[] nums3 = { 1, 1, 1, 1, 1, 1, 1, 1 };
            MinSubArrayLen(11, nums3);
        }

        public static int MinSubArrayLen(int target, int[] nums)
        {
            int left = 0;
            int right = 0;
            int sumOfCurrentWindow = 0;
            int res = int.MaxValue;

            for (right = 0; right < nums.Length; right++)
            {
                sumOfCurrentWindow += nums[right];

                while (sumOfCurrentWindow >= target)
                {
                    res = Math.Min(res, right - left + 1);
                    sumOfCurrentWindow -= nums[left++];
                }
            }

            if (res == int.MaxValue)
                res = 0;

            return res;
        }
    }
}
