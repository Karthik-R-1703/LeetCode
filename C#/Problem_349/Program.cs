using System.Collections.Generic;
using System.Linq;

namespace Problem_349
{
    // 349. Intersection of Two Arrays
    // https://leetcode.com/problems/intersection-of-two-arrays/
    internal class Program
    {
        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> num_1 = new HashSet<int>(nums1);
            HashSet<int> num_2 = new HashSet<int>(nums2);
            HashSet<int> result = new HashSet<int>();

            foreach (int num in nums1)
            {
                if (nums2.Contains(num))
                    result.Add(num);
            }

            return result.ToArray();
        }

        static void Main(string[] args)
        {
            List<int> nums1;
            List<int> nums2;

            nums1 = new List<int>() { 1, 2, 2, 1 };
            nums2 = new List<int>() { 2, 2 };
            Intersection(nums1.ToArray(), nums2.ToArray());

            nums1 = new List<int>() { 4, 9, 5 };
            nums2 = new List<int>() { 9, 4, 9, 8, 4 };
            Intersection(nums1.ToArray(), nums2.ToArray());
        }
    }
}
