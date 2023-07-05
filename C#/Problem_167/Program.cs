using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_167
{
    // 167. Two Sum II - Input Array Is Sorted
    // https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers;

            int[] numbers1 = { 2, 7, 11, 15 };
            numbers = TwoSum(numbers1, 9);

            int[] numbers2 = { 2, 3, 4 };
            numbers = TwoSum(numbers2, 6);

            int[] numbers3 = { -1, 0 };
            numbers = TwoSum(numbers3, -1);

            int[] numbers4 = { 0, 0, 3, 4 };
            numbers = TwoSum(numbers4, 0);
        }

        public static int[] TwoSum(int[] numbers, int target)
        {
            List<int> pos = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int num1 = target - numbers[i];
                if (numbers.Contains(num1) && Array.IndexOf(numbers, num1) != i)
                {
                    pos.Add(i);
                    pos.Add(Array.IndexOf(numbers, num1));
                    break;
                }
            }

            int[] p = pos.Select(i => i + 1).ToArray();
            Array.Sort(p);
            return p;
        }
    }
}
