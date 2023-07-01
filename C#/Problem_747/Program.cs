namespace Problem_747
{
    // 747. Largest Number At Least Twice of Others
    // https://leetcode.com/problems/largest-number-at-least-twice-of-others/
    internal class Program
    {
        public static int DominantIndex(int[] nums)
        {
            int index = -1;
            int max = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                    index = i;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (max == nums[i])
                {
                    continue;
                }

                if (max < 2 * nums[i])
                {
                    index = -1;
                    break;
                }
            }

            return index;
        }

        static void Main(string[] args)
        {
            int[] nums1 = { 3, 6, 1, 0 };
            DominantIndex(nums1);

            int[] nums2 = { 1, 2, 3, 4 };
            DominantIndex(nums2);
        }
    }
}
