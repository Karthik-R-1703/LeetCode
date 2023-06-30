using System.Collections.Generic;
using System.Linq;

namespace Problem_724
{
    // 724. Find Pivot Index
    // https://leetcode.com/problems/find-pivot-index/
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums;

            nums = new List<int>() { 1, 7, 3, 6, 5, 6 };
            PivotIndex(nums.ToArray());

            nums = new List<int>() { 1, 2, 3 };
            PivotIndex(nums.ToArray());

            nums = new List<int>() { 2, 1, -1 };
            PivotIndex(nums.ToArray());
        }

        public static int PivotIndex(int[] nums)
        {
            int lpi = -1;
            int l_sum = 0;
            int r_sum = nums.Sum();

            for (int i = 0; i < nums.Length; i++)
            {
                r_sum -= nums[i];
                if (l_sum == r_sum)
                {
                    lpi = i;
                    break;
                }

                l_sum += nums[i];
            }

            return lpi;
        }
    }
}
