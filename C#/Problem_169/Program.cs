using System.Collections.Generic;

namespace Problem_169
{
    // 169. Majority Element
    // https://leetcode.com/problems/majority-element/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 3, 2, 3 };
            MajorityElement(nums1);

            int[] nums2 = new int[] { 2, 2, 1, 1, 1, 2, 2 };
            MajorityElement(nums2);
        }

        public static int MajorityElement(int[] nums)
        {
            Dictionary<int, int> d_nums = new Dictionary<int, int>();
            int maxKey = 0;
            int maxCount = 0;
            foreach (int num in nums)
            {
                if (d_nums.ContainsKey(num))
                {
                    d_nums[num]++;
                }
                else
                {
                    d_nums.Add(num, 1);
                }

                if (maxCount < d_nums[num])
                {
                    maxCount = d_nums[num];
                    maxKey = num;
                }
            }

            return maxKey;
        }
    }
}
