using System.Collections.Generic;

namespace Problem_26
{
    // 26. Remove Duplicates from Sorted Array
    // https://leetcode.com/problems/remove-duplicates-from-sorted-array/
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums;

            nums = new List<int>() { 1, 1, 2 };
            RemoveDuplicates(nums.ToArray());

            nums = new List<int>() { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            RemoveDuplicates(nums.ToArray());
        }

        public static int RemoveDuplicates(int[] nums)
        {
            int left = 0;
            int right = 0;
            while (right < nums.Length)
            {
                if (nums[left] != nums[right])
                {
                    left++;
                    nums[left] = nums[right];
                }

                right++;
            }

            return left + 1;
        }
    }
}
