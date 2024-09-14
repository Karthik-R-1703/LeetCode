using System;
using System.Linq;

namespace Problem_2220
{
    // 2220. Minimum Bit Flips to Convert Number
    // https://leetcode.com/problems/minimum-bit-flips-to-convert-number/description/
    internal class Program
    {
        static void Main(string[] args)
        {
            MinBitFlips(10, 7);
        }

        public static int MinBitFlips(int start, int goal)
        {
            int xor = start ^ goal;
            return Convert.ToString(xor, 2).Count(c => c == '1');
        }
    }
}
