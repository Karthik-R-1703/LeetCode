using System.Collections.Generic;

namespace Problem_2824
{
    // 2824. Count Pairs Whose Sum is Less than Target
    // https://leetcode.com/problems/count-pairs-whose-sum-is-less-than-target/description/
    internal class Program
    {
        public static int CountPairs(IList<int> nums, int target)
        {
            int count = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                for (int j = i + 1; j < nums.Count; j++)
                {
                    if (nums[i] + nums[j] < target)
                        count++;
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            CountPairs(new List<int> { -1, 1, 2, 3, 1 }, 2);
            CountPairs(new List<int> { -6, 2, 5, -2, -7, -1, 3 }, -2);
        }
    }
}
