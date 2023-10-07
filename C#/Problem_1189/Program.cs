using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1189
{
    // 1189. Maximum Number of Balloons
    // https://leetcode.com/problems/maximum-number-of-balloons/description/
    internal class Program
    {
        static void Main(string[] args)
        {
            MaxNumberOfBalloons("nlaebolko");
            MaxNumberOfBalloons("loonbalxballpoon");
            MaxNumberOfBalloons("leetcode");
        }

        public static int MaxNumberOfBalloons(string text)
        {
            string comparer = "balloon";
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach (char c in text)
            {
                if (comparer.Contains(c))
                {
                    if (charCount.ContainsKey(c))
                        charCount[c]++;
                    else
                        charCount.Add(c, 1);
                }
            }

            if (charCount.Count != 5)
                return 0;

            charCount['l'] /= 2;
            charCount['o'] /= 2;

            int count = int.MaxValue;
            foreach (int c in charCount.Values)
            {
                count = Math.Min(count, c);
            }

            return count;
        }
    }
}
