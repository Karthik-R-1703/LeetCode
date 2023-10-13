using System;

namespace Problem_746
{
    // 746. Min Cost Climbing Stairs
    // https://leetcode.com/problems/min-cost-climbing-stairs/description/
    internal class Program
    {
        static void Main(string[] args)
        {
            MinCostClimbingStairs(new int[] { 10, 15, 20 });
            MinCostClimbingStairs(new int[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 });
        }

        public static int MinCostClimbingStairs(int[] cost)
        {
            int[] dp = new int[cost.Length + 1];
            for (int i = 2; i <= cost.Length; i++)
            {
                dp[i] = Math.Min(dp[i - 1] + cost[i - 1], dp[i - 2] + cost[i - 2]);
            }

            return dp[cost.Length];
        }
    }
}
