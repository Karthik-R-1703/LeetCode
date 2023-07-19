using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_350
{
    // 350. Intersection of Two Arrays II
    // https://leetcode.com/problems/intersection-of-two-arrays-ii/
    internal class Program
    {
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> nums_1 = nums1.GroupBy(x => x).ToDictionary(y => y.Key, y => y.Count());
            Dictionary<int, int> nums_2 = nums2.GroupBy(x => x).ToDictionary(y => y.Key, y => y.Count());
            List<int> result = new List<int>();
            foreach (KeyValuePair<int, int> keyValuePair in nums_1)
            {
                if (nums_2.ContainsKey(keyValuePair.Key))
                {
                    int value_1 = keyValuePair.Value;
                    int value_2 = nums_2[keyValuePair.Key];
                    int min = Math.Min(value_1, value_2);
                    for (int i = 0; i < min; i++)
                        result.Add(keyValuePair.Key);
                }
            }

            return result.ToArray();
        }

        static void Main(string[] args)
        {
            List<int> nums1;
            List<int> nums2;

            nums1 = new List<int>() { 1, 2, 2, 1 };
            nums2 = new List<int>() { 2, 2 };
            Intersect(nums1.ToArray(), nums2.ToArray());

            nums1 = new List<int>() { 4, 9, 5 };
            nums2 = new List<int>() { 9, 4, 9, 8, 4 };
            Intersect(nums1.ToArray(), nums2.ToArray());
        }
    }
}
