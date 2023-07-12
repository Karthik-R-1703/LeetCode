using System;
using System.Collections.Generic;

namespace Problem_179
{
    class String_IComparer : IComparer<string>
    {
        public int Compare(string a, string b)
        {
            string order1 = a + b;
            string order2 = b + a;
            return order1.CompareTo(order2);
        }
    }

    // 179. Largest Number
    // https://leetcode.com/problems/largest-number/
    internal class Program
    {
        public static string LargestNumber(int[] nums)
        {
            string largestNumber = string.Empty;
            string[] s_nums = new string[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                s_nums[i] = nums[i].ToString();
            }

            Array.Sort(s_nums, new String_IComparer());

            if (s_nums[s_nums.Length - 1].Equals("0"))
                return "0";

            for (int i = s_nums.Length - 1; i >= 0; i--)
            {
                largestNumber += s_nums[i];
            }

            return largestNumber;
        }

        static void Main(string[] args)
        {
            int[] nums1 = { 10, 2 };
            LargestNumber(nums1);

            int[] nums2 = { 3, 30, 34, 5, 9 };
            LargestNumber(nums2);

            int[] nums3 = { 0, 0 };
            LargestNumber(nums3);

            int[] nums4 = { 8308, 8308, 830 };
            LargestNumber(nums4);
            LargestNumber(nums3);

            int[] nums5 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            LargestNumber(nums5);
        }
    }
}
