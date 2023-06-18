using System.Collections.Generic;
using System.Linq;

namespace Problem_347
{
    // 347. Top K Frequent Elements
    // https://leetcode.com/problems/top-k-frequent-elements/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 1, 2, 2, 3 };
            TopKFrequent(nums, 2);
        }

        public static int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> frequency = nums.GroupBy(i => i).ToDictionary(i => i.Key, i => i.Count());
            int[] topKFrequent = frequency.OrderByDescending(i => i.Value).Select(i => i.Key).Take(k).ToArray();
            return topKFrequent;
        }
    }
}
