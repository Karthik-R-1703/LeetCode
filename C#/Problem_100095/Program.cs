using System.Collections.Generic;

namespace Problem_100095
{
    // 100095. Last Visited Integers
    // 2899. Last Visited Integers
    // https://leetcode.com/problems/last-visited-integers/description/
    internal class Program
    {
        public static IList<int> LastVisitedIntegers(IList<string> words)
        {
            List<int> result = new List<int>();
            List<int> nums = new List<int>();
            int i = -1;
            foreach (string word in words)
            {
                if (word.Equals("prev"))
                {
                    if (i > -1)
                    {
                        result.Add(nums[i]);
                        i--;
                    }
                    else
                    {
                        result.Add(-1);
                    }
                }
                else
                {
                    nums.Add(int.Parse(word));
                    i = nums.Count - 1;
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            LastVisitedIntegers(new List<string> { "1", "2", "prev", "prev", "prev" });
            LastVisitedIntegers(new List<string> { "1", "prev", "2", "prev", "prev" });
        }
    }
}
