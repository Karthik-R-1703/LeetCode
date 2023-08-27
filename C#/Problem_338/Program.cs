using System;
using System.Collections.Generic;

namespace Problem_338
{
    // 338. Counting Bits
    // https://leetcode.com/problems/counting-bits/
    internal class Program
    {
        public static Dictionary<int, int> BitsCount = new Dictionary<int, int>();

        public static int CalculateBits(int num)
        {
            int numOfOnes = 0;

            if (BitsCount.ContainsKey(num))
            {
                return BitsCount[num];
            }

            int closestPower = (int)Math.Round(Math.Log(num, 2));
            int closestValue = (int)Math.Pow(2, closestPower);

            BitsCount.Add(num, numOfOnes);
            return numOfOnes;
        }

        public static int[] CountBits(int n)
        {
            int[] numOfBits = new int[n + 1];
            for (int i = 0; i <= n; i++)
            {
                numOfBits[i] = CalculateBits(i);
            }

            return numOfBits;
        }

        static void Main(string[] args)
        {
            CountBits(2);
            CountBits(5);
        }
    }
}
