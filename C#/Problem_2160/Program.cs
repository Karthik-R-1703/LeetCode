using System;

namespace Problem_2160
{
    // 2160. Minimum Sum of Four Digit Number After Splitting Digits
    // https://leetcode.com/problems/minimum-sum-of-four-digit-number-after-splitting-digits/description/
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static int MinimumSum(int num)
        {
            char[] chars = num.ToString().ToCharArray();
            int[] nums = new int[4];
            for (int i = 0; i < 4; i++)
            {
                nums[i] = int.Parse(chars[i].ToString());
            }

            Array.Sort(nums);
            int num1 = nums[0] * 10 + nums[2];
            int num2 = nums[1] * 10 + nums[3];
            return num1 + num2;
        }
    }
}
