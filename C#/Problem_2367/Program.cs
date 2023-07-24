using System.Collections.Generic;

namespace Problem_2367
{
    // 2367. Number of Arithmetic Triplets
    // https://leetcode.com/problems/number-of-arithmetic-triplets/
    internal class Program
    {
        public static int ArithmeticTriplets(int[] nums, int diff)
        {
            int count = 0;
            HashSet<int> triplets = new HashSet<int>(nums);
            foreach (int i in triplets)
            {
                if (triplets.Contains(i - diff) && triplets.Contains(i - (2 * diff)))
                    count++;
            }

            return count;
        }

        static void Main(string[] args)
        {
            int[] nums1 = { 0, 1, 4, 6, 7, 10 };
            ArithmeticTriplets(nums1, 3);

            int[] nums2 = { 4, 5, 6, 7, 8, 9 };
            ArithmeticTriplets(nums2, 2);
        }
    }
}
