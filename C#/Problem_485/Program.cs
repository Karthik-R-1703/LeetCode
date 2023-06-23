using System;

namespace Problem_485
{
    // 485. Max Consecutive Ones
    // https://leetcode.com/problems/max-consecutive-ones/
    internal class Program
    {
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            int maxConsecutiveOnes = 0;
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    count++;
                }
                else
                {
                    maxConsecutiveOnes = Math.Max(maxConsecutiveOnes, count);
                    count = 0;
                }
            }

            maxConsecutiveOnes = Math.Max(maxConsecutiveOnes, count);
            return maxConsecutiveOnes;
        }

        static void Main(string[] args)
        {
            int[] nums1 = { 1, 1, 0, 1, 1, 1 };
            FindMaxConsecutiveOnes(nums1);

            int[] nums2 = { 1, 0, 1, 1, 0, 1 };
            FindMaxConsecutiveOnes(nums2);
        }
    }
}
