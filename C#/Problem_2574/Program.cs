using System;

namespace Problem_2574
{
    // 2574. Left and Right Sum Differences
    // https://leetcode.com/problems/left-and-right-sum-differences/description/
    internal class Program
    {
        public static int[] LeftRightDifference(int[] nums)
        {
            int[] leftSum = new int[nums.Length];
            int[] rightSum = new int[nums.Length];
            int[] answer = new int[nums.Length];

            for (int i = 1; i < nums.Length; i++)
            {
                leftSum[i] = nums[i - 1] + leftSum[i - 1];
            }

            for (int i = nums.Length - 2; i > -1; i--)
            {
                rightSum[i] = nums[i + 1] + rightSum[i + 1];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                answer[i] = Math.Abs(leftSum[i] - rightSum[i]);
            }

            return answer;
        }

        static void Main(string[] args)
        {
            LeftRightDifference(new int[] { 10, 4, 8, 3 });
            LeftRightDifference(new int[] { 1 });
        }
    }
}
