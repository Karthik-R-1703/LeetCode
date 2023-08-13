using System;
using System.Collections.Generic;

namespace Problem_7022
{
    // 7022. Minimum Absolute Difference Between Elements With Constraint
    // 2817. Minimum Absolute Difference Between Elements With Constraint
    // https://leetcode.com/problems/minimum-absolute-difference-between-elements-with-constraint/
    internal class Program
    {
        // Helper function to get the closest number from a sorted list
        private static int GetClosest(SortedList<int, int> sortedList, int num)
        {
            if (sortedList.ContainsKey(num))
                return num;

            var keys = sortedList.Keys;

            int left = 0, right = keys.Count - 1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (keys[mid] < num)
                    left = mid + 1;
                else
                    right = mid;
            }

            if (left == 0)
                return keys[0];
            if (left == keys.Count)
                return keys[keys.Count - 1];

            int prev = keys[left - 1];
            int next = keys[left];

            if (Math.Abs(prev - num) <= Math.Abs(next - num))
                return prev;
            return next;
        }

        static void Main(string[] args)
        {
            int min1 = MinAbsoluteDifference(new int[] { 4, 3, 2, 4 }, 2);
            int min2 = MinAbsoluteDifference(new int[] { 5, 3, 2, 10, 15 }, 1);
            int min3 = MinAbsoluteDifference(new int[] { 1, 2, 3, 4 }, 3);
        }

        public static int MinAbsoluteDifference(IList<int> nums, int x)
        {
            int n = nums.Count;
            int res = int.MaxValue;

            // A sorted list to maintain the window of size x
            SortedList<int, int> sortedWindow = new SortedList<int, int>();

            // Initialize the sorted list with the first x numbers
            for (int i = 0; i < x; i++)
            {
                if (!sortedWindow.ContainsKey(nums[i]))
                    sortedWindow[nums[i]] = 0;

                sortedWindow[nums[i]]++;
            }

            // Start the sliding window from x to n-1
            for (int j = x; j < n; j++)
            {
                // Get the closest number in the sorted list for nums[j]
                int closest = GetClosest(sortedWindow, nums[j]);

                // Update the result
                res = Math.Min(res, Math.Abs(nums[j] - closest));

                // Remove the leftmost element from the sorted list
                if (sortedWindow[nums[j - x]] == 1)
                    sortedWindow.Remove(nums[j - x]);
                else
                    sortedWindow[nums[j - x]]--;

                // Add the current number to the sorted list
                if (!sortedWindow.ContainsKey(nums[j]))
                    sortedWindow[nums[j]] = 0;

                sortedWindow[nums[j]]++;
            }

            return res;
        }
    }
}
