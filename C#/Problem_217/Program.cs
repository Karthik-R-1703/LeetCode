using System.Collections.Generic;

namespace Problem_217
{
    // 217. Contains Duplicate
    // https://leetcode.com/problems/contains-duplicate/
    internal class Program
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();

            foreach (int num in nums)
            {
                if (set.Contains(num))
                {
                    return true;
                }

                set.Add(num);
            }

            return false;
        }

        static void Main(string[] args)
        {
        }
    }
}
