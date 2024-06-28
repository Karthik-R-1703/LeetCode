using System;
using System.Collections.Generic;

namespace Problem_100224
{
    // 100224. Split the Array
    // 3046. Split the Array
    // https://leetcode.com/problems/split-the-array/description/
    internal class Program
    {
        public static bool IsPossibleToSplit(int[] nums)
        {
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (frequencyMap.ContainsKey(num))
                {
                    frequencyMap[num]++;
                    if (frequencyMap[num] > 2)
                        return false;
                }
                else
                    frequencyMap[num] = 1;
            }

            return true;
        }

        static void Main(string[] args)
        {
            int[] nums1 = { 1, 1, 2, 2, 3, 4 };
            int[] nums2 = { 1, 1, 1, 1 };
            int[] nums3 = { 6, 1, 3, 1, 1, 8, 9, 2 };
            int[] nums4 = { 10, 10 };

            Console.WriteLine(IsPossibleToSplit(nums1));
            Console.WriteLine(IsPossibleToSplit(nums2));
            Console.WriteLine(IsPossibleToSplit(nums3));
            Console.WriteLine(IsPossibleToSplit(nums4));
            Console.ReadKey();
        }
    }
}
