using System;

namespace Problem_1829
{
    // 1829. Maximum XOR for Each Query
    // https://leetcode.com/problems/maximum-xor-for-each-query/description/
    internal class Program
    {
        public static int[] GetMaximumXor(int[] nums, int maximumBit)
        {
            int n = nums.Length;
            int[] result = new int[n];
            int maximized = (int)Math.Pow(2, maximumBit) - 1;
            int preXor = 0;
            for (int i = 0; i < n; i++)
            {
                int curXor = preXor ^ nums[i];
                result[n - 1 - i] = curXor ^ maximized;
                preXor = curXor;
            }

            return result;
        }

        static void Main(string[] args)
        {
        }
    }
}
