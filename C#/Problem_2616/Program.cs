using System;

namespace Problem_2616
{
    // 2616. Minimize the Maximum Difference of Pairs
    // https://leetcode.com/problems/minimize-the-maximum-difference-of-pairs/
    internal class Program
    {
        static void Main(string[] args)
        {
            MinimizeMax(new int[] { 10, 1, 2, 7, 1, 3 }, 2);
            MinimizeMax(new int[] { 4, 2, 1, 2 }, 1);
            MinimizeMax(new int[] { 3, 4, 2, 3, 2, 1, 2 }, 3);
        }

        public static int MinimizeMax(int[] nums, int p)
        {
            if (p == 0)
                return 0;

            Array.Sort(nums);
            int[] min = new int[nums.Length - 1];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                min[i] = nums[i + 1] - nums[i];
            }

            Array.Sort(min);
            int max = int.MinValue;
            for (int i = 0; i < p; i++)
            {
                if (min[i] > max)
                    max = min[i];
            }

            return max;
        }
    }
}
