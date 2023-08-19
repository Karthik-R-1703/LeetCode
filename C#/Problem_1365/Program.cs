using System;

namespace Problem_1365
{
    // 1365. How Many Numbers Are Smaller Than the Current Number
    // https://leetcode.com/problems/how-many-numbers-are-smaller-than-the-current-number/
    internal class Program
    {
        static void Main(string[] args)
        {
            SmallerNumbersThanCurrent(nums: new[] { 8, 1, 2, 2, 3 });
            SmallerNumbersThanCurrent(nums: new[] { 6, 5, 4, 8 });
            SmallerNumbersThanCurrent(nums: new[] { 7, 7, 7, 7 });
        }

        public static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] result = new int[nums.Length];
            int[] copy = (int[])nums.Clone();
            Array.Sort(copy);
            for (int i = 0; i < nums.Length; i++)
            {
                int j = Array.IndexOf(copy, nums[i]);
                result[i] = j;
            }

            return result;
        }
    }
}
