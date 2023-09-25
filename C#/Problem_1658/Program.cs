using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1658
{
    // 1658. Minimum Operations to Reduce X to Zero
    // https://leetcode.com/problems/minimum-operations-to-reduce-x-to-zero/description/
    internal class Program
    {
        static void Main(string[] args)
        {
            MinOperations(new int[] { 1, 1, 4, 2, 3 }, 5);
            MinOperations(new int[] { 5, 6, 7, 8, 9 }, 4);
            MinOperations(new int[] { 3, 2, 20, 1, 1, 3 }, 10);
        }

        public static int MinOperations(int[] nums, int x)
        {
            int n = nums.Length;
            int target = nums.Sum() - x;

            if (target == 0)
                return n;

            Dictionary<int, int> prefixSum = new Dictionary<int, int>();
            prefixSum[0] = -1;
            int currentSum = 0;
            int maxLength = -1;

            for (int i = 0; i < n; i++)
            {
                currentSum += nums[i];

                if (prefixSum.ContainsKey(currentSum - target))
                {
                    int length = i - prefixSum[currentSum - target];
                    maxLength = Math.Max(maxLength, length);
                }

                prefixSum[currentSum] = i;
            }

            return maxLength == -1 ? -1 : n - maxLength;
        }
    }
}
