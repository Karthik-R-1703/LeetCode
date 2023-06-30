using System.Collections.Generic;

namespace Problem_448
{
    // 448. Find All Numbers Disappeared in an Array
    // https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/
    internal class Program
    {
        public static IList<int> FindDisappearedNumbers(int[] nums)
        {
            List<int> m_nums = new List<int>();
            int i = 0;

            while (i < nums.Length)
            {
                if (nums[i] == i + 1)
                {
                    i++;
                }
                else
                {
                    int t = nums[nums[i] - 1];
                    if (t != nums[i])
                    {
                        nums[nums[i] - 1] = nums[i];
                        nums[i] = t;
                    }
                    else
                    {
                        i++;
                    }
                }
            }

            for (i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i + 1)
                {
                    m_nums.Add(i + 1);
                }
            }

            return m_nums;
        }

        static void Main(string[] args)
        {
            List<int> nums;

            nums = new List<int>() { 4, 3, 2, 7, 8, 2, 3, 1 };
            FindDisappearedNumbers(nums.ToArray());

            nums = new List<int>() { 1, 1 };
            FindDisappearedNumbers(nums.ToArray());
        }
    }
}
