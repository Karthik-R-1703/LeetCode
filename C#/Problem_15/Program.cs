using System;
using System.Collections.Generic;

namespace Problem_15
{
    // 15. 3Sum
    // https://leetcode.com/problems/3sum/
    internal class Program
    {
        static void Main(string[] args)
        {
            ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 });
            ThreeSum(new int[] { 0, 1, 1 });
            ThreeSum(new int[] { 0, 0, 0 });
            ThreeSum(new int[] { 0, 0, 0, 0 });
        }

        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            List<IList<int>> pairs = new List<IList<int>>();
            int i = 0;
            while (i < nums.Length - 2)
            {
                int a = nums[i];
                int j = i + 1;
                int k = nums.Length - 1;
                while (j < k)
                {
                    int b = nums[j];
                    int c = nums[k];
                    if (a + b + c == 0)
                    {
                        pairs.Add(new List<int>() { a, b, c });

                        while (j < k && b == nums[j])
                            j++;

                        while (k > j && c == nums[k])
                            k--;
                    }
                    else if (a + b + c < 0)
                    {
                        j++;
                    }
                    else
                    {
                        k--;
                    }
                }

                int start = nums[i];
                while (i < nums.Length - 2 && nums[i] == start)
                    i++;
            }

            return pairs;
        }
    }
}
