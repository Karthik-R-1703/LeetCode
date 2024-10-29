using System;
using System.Linq;

namespace Problem_100443
{
    // 100443. Find the Maximum Factor Score of Array
    // 3334. Find the Maximum Factor Score of Array
    // https://leetcode.com/problems/find-the-maximum-factor-score-of-array/description/
    internal class Program
    {
        private static long GCD(long a, long b)
        {
            while (b != 0)
            {
                long temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        private static long GCDArray(long[] nums)
        {
            return nums.Aggregate(GCD);
        }

        private static long LCM(long a, long b)
        {
            return (a / GCD(a, b)) * b;
        }

        private static long LCMArray(long[] nums)
        {
            return nums.Aggregate(1L, LCM);
        }

        static void Main(string[] args)
        {
            MaxFactorScore(new int[] { 2, 4, 8, 16 });
            MaxFactorScore(new int[] { 1, 2, 3, 4, 5 });
            MaxFactorScore(new int[] { 3 });
            MaxFactorScore(new int[] { 16, 25, 7, 27, 11, 13, 17, 19, 23, 29 });
        }

        public static long MaxFactorScore(int[] nums)
        {
            long[] longNums = Array.ConvertAll(nums, i => (long)i);
            int n = longNums.Length;
            if (n == 0)
                return 0;

            long overallGCD = GCDArray(longNums);
            long overallLCM = LCMArray(longNums);
            long maxScore = overallGCD * overallLCM;
            for (int i = 0; i < n; i++)
            {
                long[] newNums = longNums.Where((_, index) => index != i).ToArray();
                if (newNums.Length > 0)
                {
                    long newGCD = GCDArray(newNums);
                    long newLCM = LCMArray(newNums);
                    maxScore = Math.Max(maxScore, newGCD * newLCM);
                }
            }

            return maxScore;
        }
    }
}
