using System.Collections.Generic;
using System.Linq;

namespace Problem_2215
{
    // 2215. Find the Difference of Two Arrays
    // https://leetcode.com/problems/find-the-difference-of-two-arrays/
    internal class Program
    {
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            HashSet<int> nums_1 = new HashSet<int>(nums1);
            HashSet<int> nums_2 = new HashSet<int>(nums2);

            foreach (int i in nums_1)
            {
                if (nums_2.Contains(i))
                {
                    nums_1.Remove(i);
                    nums_2.Remove(i);
                }
            }

            List<IList<int>> result = new List<IList<int>>
            {
                nums_1.ToList(),
                nums_2.ToList()
            };

            return result;
        }

        static void Main(string[] args)
        {
        }
    }
}
