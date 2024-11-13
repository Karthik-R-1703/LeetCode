using System;

namespace Problem_2563
{
    // 2563. Count the Number of Fair Pairs
    // https://leetcode.com/problems/count-the-number-of-fair-pairs/description/
    internal class Program
    {
        private static int BinarySearch(int[] nums, int start, int end, int num)
        {
            while (start <= end)
            {
                int mid = start + ((end - start) / 2);
                if (nums[mid] >= num)
                    end = mid - 1;
                else
                    start = mid + 1;
            }

            return start;
        }

        public static long CountFairPairs(int[] nums, int lower, int upper)
        {
            long count = 0;
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                int low = BinarySearch(nums, i + 1, nums.Length - 1, lower - nums[i]);
                int high = BinarySearch(nums, i + 1, nums.Length - 1, upper - nums[i] + 1);
                count += high - low;
            }

            return count;
        }

        static void Main(string[] args)
        {
            CountFairPairs(new int[] { 0, 1, 7, 4, 4, 5 }, 3, 6);
        }
    }
}
