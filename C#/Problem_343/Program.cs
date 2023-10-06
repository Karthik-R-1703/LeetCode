using System;
using System.Collections.Generic;

namespace Problem_343
{
    // 343. Integer Break
    // https://leetcode.com/problems/integer-break/description/
    internal class Program
    {
        public static Dictionary<int, int> maxProduct = new Dictionary<int, int>();

        public static int IntegerBreak(int n)
        {
            if (n <= 3)
                return n - 1;

            return MaxInteger(n);
        }

        static void Main(string[] args)
        {
            IntegerBreak(2);
            IntegerBreak(10);
        }

        public static int MaxInteger(int n)
        {
            if (n <= 4)
                return n;

            if (maxProduct.ContainsKey(n))
                return maxProduct[n];

            int result = n;
            for (int i = 2; i < n; i++)
            {
                result = Math.Max(result, i * MaxInteger(n - i));
            }

            maxProduct.Add(n, result);
            return result;
        }
    }
}
