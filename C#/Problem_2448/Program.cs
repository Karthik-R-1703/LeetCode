using System;

namespace Problem_2448
{
    // 2448. Minimum Cost to Make Array Equal
    // https://leetcode.com/problems/minimum-cost-to-make-array-equal/
    internal class Program
    {
        public static long MinCost(int[] nums, int[] cost)
        {
            long minCost = long.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                long average = nums[i];
                long tempCost = 0;

                for (int j = 0; j < nums.Length; j++)
                {
                    long c = average - nums[j];
                    tempCost += (Math.Abs(c) * cost[j]);

                    if (tempCost > minCost)
                    {
                        break;
                    }
                }

                if (tempCost < minCost)
                {
                    minCost = tempCost;
                }
            }

            return minCost;
        }

        static void Main(string[] args)
        {
            int[] nums = { 735103, 366367, 132236, 133334, 808160, 113001, 49051, 735598, 686615, 665317, 999793, 426087, 587000, 649989, 509946, 743518 };
            int[] cost = { 724182, 447415, 723725, 902336, 600863, 287644, 13836, 665183, 448859, 917248, 397790, 898215, 790754, 320604, 468575, 825614 };
            long exp = 1907611126748;
            long minCost = MinCost(nums, cost);
        }
    }
}
