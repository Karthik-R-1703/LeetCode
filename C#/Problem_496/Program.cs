using System;

namespace Problem_496
{
    // 496. Next Greater Element I
    // https://leetcode.com/problems/next-greater-element-i/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1_1 = { 4, 1, 2 };
            int[] nums1_2 = { 1, 3, 4, 2 };
            NextGreaterElement(nums1_1, nums1_2);

            int[] nums2_1 = { 2, 4 };
            int[] nums2_2 = { 1, 2, 3, 4 };
            NextGreaterElement(nums2_1, nums2_2);
        }

        public static int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            int[] result = new int[nums1.Length];
            for (int n = 0; n < nums1.Length; n++)
            {
                int index = Array.IndexOf(nums2, nums1[n]);
                int max = nums1[n];
                for (int i = index + 1; i < nums2.Length; i++)
                {
                    if (nums2[i] > max)
                    {
                        max = nums2[i];
                        break;
                    }
                }

                if (max == nums1[n])
                    result[n] = -1;
                else
                    result[n] = max;
            }

            return result;
        }
    }
}
