using System;

namespace Problem_1509
{
    // 1509. Minimum Difference Between Largest and Smallest Value in Three Moves
    // https://leetcode.com/problems/minimum-difference-between-largest-and-smallest-value-in-three-moves/description/
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static int MinDifference(int[] nums)
        {
            int n = nums.Length;
            if (n <= 4)
                return 0;

            int Min = int.MaxValue;
            Array.Sort(nums);
            for (int left = 0, right = n - 4; left < 4; left++, right++)
            {
                Min = Math.Min(Min, nums[right] - nums[left]);
            }

            return Min;
        }
    }
}
