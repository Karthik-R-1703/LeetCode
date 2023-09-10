using System.Collections.Generic;

namespace Problem_1137
{
    // 1137. N-th Tribonacci Number
    // https://leetcode.com/problems/n-th-tribonacci-number/
    internal class Program
    {
        public static Dictionary<int, int> TribonacciMap = new Dictionary<int, int>()
        {
            {0,0},
            {1,1},
            {2,1}
        };

        static void Main(string[] args)
        {
            Tribonacci(4);
            Tribonacci(25);
        }

        public static int Tribonacci(int n)
        {
            if (!TribonacciMap.ContainsKey(n))
            {
                TribonacciMap.Add(n, Tribonacci(n - 1) + Tribonacci(n - 2) + Tribonacci(n - 3));
            }

            return TribonacciMap[n];
        }
    }
}
