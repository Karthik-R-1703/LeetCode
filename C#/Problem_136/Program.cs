using System.Collections.Generic;
using System.Linq;

namespace Problem_136
{
    // 136. Single Number
    // https://leetcode.com/problems/single-number/
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public int SingleNumber(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (int x in nums)
            {
                if (set.Contains(x))
                {
                    set.Remove(x);
                }
                else
                {
                    set.Add(x);
                }
            }

            return set.First();
        }
    }
}
