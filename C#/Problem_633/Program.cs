using System;

namespace Problem_633
{
    // 633. Sum of Square Numbers
    // https://leetcode.com/problems/sum-of-square-numbers/description/
    internal class Program
    {
        public static bool JudgeSquareSum(int c)
        {
            for (long a = 0; a * a <= c; a++)
            {
                double b = Math.Sqrt(c - a * a);
                if (b % 1 == 0)
                    return true;
            }

            return false;
        }

        static void Main(string[] args)
        {
        }
    }
}
