using System.Collections.Generic;

namespace Problem_88
{
    // 88. Merge Sorted Array
    // https://leetcode.com/problems/merge-sorted-array/
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums1;
            List<int> nums2;

            nums1 = new List<int>() { 1, 2, 3, 0, 0, 0 };
            nums2 = new List<int>() { 2, 5, 6 };
            Merge(nums1.ToArray(), 3, nums2.ToArray(), 3);

            nums1 = new List<int>() { 1 };
            nums2 = new List<int>() { };
            Merge(nums1.ToArray(), 1, nums2.ToArray(), 0);

            nums1 = new List<int>() { 0 };
            nums2 = new List<int>() { 1 };
            Merge(nums1.ToArray(), 0, nums2.ToArray(), 1);
        }

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = m + n - 1; i >= 0; i--)
            {
                int num1 = int.MinValue;
                int num2 = int.MinValue;

                if (m - 1 >= 0)
                {
                    num1 = nums1[m - 1];
                }

                if (n - 1 >= 0)
                {
                    num2 = nums2[n - 1];
                }

                if (num1 > num2)
                {
                    nums1[i] = num1;
                    m--;
                }
                else
                {
                    nums1[i] = num2;
                    n--;
                }
            }
        }
    }
}
