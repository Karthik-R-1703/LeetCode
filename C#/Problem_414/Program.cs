using System;
using System.Collections.Generic;

namespace Problem_414
{
    // 414. Third Maximum Number
    // https://leetcode.com/problems/third-maximum-number/
    internal class Program
    {
        static void Main(string[] args)
        {
            int thirdMax = int.MinValue;
            List<int> nums;

            nums = new List<int>() { 3, 2, 1 };
            thirdMax = ThirdMax(nums.ToArray());

            nums = new List<int>() { 1, 2 };
            thirdMax = ThirdMax(nums.ToArray());

            nums = new List<int>() { 2, 2, 3, 1 };
            thirdMax = ThirdMax(nums.ToArray());
        }

        public static int ThirdMax(int[] nums)
        {
            long FirstMax = long.MinValue;
            long SecondMax = long.MinValue;
            long ThirdMax = long.MinValue;

            foreach (int x in nums)
            {
                if (x > FirstMax)
                {
                    ThirdMax = SecondMax;
                    SecondMax = FirstMax;
                    FirstMax = x;
                }
                else if (x == FirstMax)
                {
                }
                else if (x > SecondMax)
                {
                    ThirdMax = SecondMax;
                    SecondMax = x;
                }
                else if (x == SecondMax)
                {
                }
                else if (x > ThirdMax)
                {
                    ThirdMax = x;
                }
            }

            if (FirstMax != int.MinValue && SecondMax != int.MinValue && ThirdMax != int.MinValue)
            {
                return (int)ThirdMax;
            }
            else
            {
                return (int)Math.Max(Math.Max(FirstMax, SecondMax), Math.Max(ThirdMax, 0));
            }
        }
    }
}
