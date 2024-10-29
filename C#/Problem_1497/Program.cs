using System.Collections.Generic;

namespace Problem_1497
{
    // 1497. Check If Array Pairs Are Divisible by k
    // https://leetcode.com/problems/check-if-array-pairs-are-divisible-by-k/description/
    internal class Program
    {
        public static bool CanArrange(int[] arr, int k)
        {
            Dictionary<int, int> remainderCount = new Dictionary<int, int>();
            foreach (int i in arr)
            {
                int remainder = (i % k + k) % k;
                if (remainderCount.ContainsKey(remainder))
                    remainderCount[remainder]++;
                else
                    remainderCount.Add(remainder, 1);
            }

            foreach (int i in arr)
            {
                int remainder = (i % k + k) % k;
                if (remainder == 0)
                {
                    if (remainderCount[remainder] % 2 == 1)
                        return false;
                }
                else if (!remainderCount.ContainsKey(k - remainder))
                    return false;
                else if (remainderCount[remainder] != remainderCount[k - remainder])
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 10, 6, 7, 8, 9 };
            CanArrange(arr1, 5);

            int[] arr2 = { 1, 2, 3, 4, 5, 6 };
            CanArrange(arr2, 7);

            int[] arr3 = { 1, 2, 3, 4, 5, 6 };
            CanArrange(arr3, 10);

            int[] arr4 = { -1, 1, -2, 2, -3, 3, -4, 4 };
            CanArrange(arr4, 3);
        }
    }
}
