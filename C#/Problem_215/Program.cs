using System.Linq;

namespace Problem_215
{
    // 215. Kth Largest Element in an Array
    // https://leetcode.com/problems/kth-largest-element-in-an-array/
    internal class Program
    {
        public static int FindKthLargest(int[] nums, int k)
        {
            int max = nums.Max();
            int min = nums.Min();
            int[] count = new int[max - min + 2];

            foreach (int num in nums)
            {
                count[num - min]++;
            }

            for (int i = count.Length - 1; i >= 0; i--)
            {
                int c = count[i];
                k -= c;
                if (k <= 0)
                {
                    return i + min;
                }
            }

            return k;
        }

        static void Main(string[] args)
        {
            FindKthLargest(new int[] { 3, 2, 1, 5, 6, 4 }, 2);
            FindKthLargest(new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4);
            FindKthLargest(new int[] { 99, 99 }, 1);
            FindKthLargest(new int[] { -1, -1 }, 2);
        }
    }
}
