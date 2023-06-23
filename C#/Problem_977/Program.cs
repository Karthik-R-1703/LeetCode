using System;

namespace Problem_977
{
    // 977. Squares of a Sorted Array
    // https://leetcode.com/problems/squares-of-a-sorted-array/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { -4, -1, 0, 3, 10 };
            SortedSquares(nums1);

            int[] nums2 = { -7, -3, 2, 3, 11 };
            SortedSquares(nums2);
        }

        public static int[] SortedSquares(int[] nums)
        {
            int[] sortedSquares = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                sortedSquares[i] = nums[i] * nums[i];
            }

            Array.Sort(sortedSquares);
            return sortedSquares;
        }
    }
}
