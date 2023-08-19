using System.Collections.Generic;

namespace Problem_1512
{
    // 1512. Number of Good Pairs
    // https://leetcode.com/problems/number-of-good-pairs/
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public int NumIdenticalPairs(int[] nums)
        {
            Dictionary<int, int> numCount = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (numCount.ContainsKey(num))
                    numCount[num]++;
                else
                    numCount.Add(num, 1);
            }

            int pairs = 0;
            foreach (int counts in numCount.Values)
            {
                int v = counts * (counts - 1) / 2;
                pairs += v;
            }

            return pairs;
        }
    }
}
