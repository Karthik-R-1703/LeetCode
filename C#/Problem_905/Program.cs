using System.Collections.Generic;

namespace Problem_905
{
    // 905. Sort Array By Parity
    // https://leetcode.com/problems/sort-array-by-parity/
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums;

            nums = new List<int>() { 3, 1, 2, 4 };
            SortArrayByParity(nums.ToArray());

            nums = new List<int>() { 0 };
            SortArrayByParity(nums.ToArray());
        }

        public static int[] SortArrayByParity(int[] nums)
        {
            int[] sortedArray = new int[nums.Length];
            int left = 0;
            int right = nums.Length - 1;

            foreach (int num in nums)
            {
                if (num % 2 == 0)
                {
                    sortedArray[left] = num;
                    left++;
                }
                else
                {
                    sortedArray[right] = num;
                    right--;
                }
            }

            return sortedArray;
        }
    }
}
