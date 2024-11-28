using System;

namespace Problem_1574
{
    // 1574. Shortest Subarray to be Removed to Make Array Sorted
    // https://leetcode.com/problems/shortest-subarray-to-be-removed-to-make-array-sorted/description/
    internal class Program
    {
        public static int FindLengthOfShortestSubarray(int[] arr)
        {
            int r = arr.Length - 1;
            while (r > 0 && arr[r] >= arr[r - 1])
                r--;

            int minLength = r;
            int l = 0;
            while (l < r && (l == 0 || arr[l - 1] <= arr[l]))
            {
                while (r < arr.Length && arr[l] > arr[r])
                    r++;

                minLength = Math.Min(minLength, r - l - 1);
                l++;
            }

            return minLength;
        }

        static void Main(string[] args)
        {
            FindLengthOfShortestSubarray(new int[] { 1, 2, 3, 10, 4, 2, 3, 5 });
            FindLengthOfShortestSubarray(new int[] { 2, 2, 2, 1, 1, 1 });
            FindLengthOfShortestSubarray(new int[] { 6, 3, 10, 11, 15, 20, 13, 3, 18, 12 });
        }
    }
}
