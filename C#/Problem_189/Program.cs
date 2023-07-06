namespace Problem_189
{
    // 189. Rotate Array
    // https://leetcode.com/problems/rotate-array/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 4, 5, 6, 7 };
            Rotate(nums1, 3);

            int[] nums2 = { -1, -100, 3, 99 };
            Rotate(nums2, 2);
        }

        public static void Reverse(int[] nums, int start, int end)
        {
            for (int i = 0; i <= (end - start) / 2; i++)
            {
                (nums[i + start], nums[end - i]) = (nums[end - i], nums[i + start]);
            }
        }

        public static void Rotate(int[] nums, int k)
        {
            k %= nums.Length;

            if (nums.Length <= 1 || k == 0)
                return;

            Reverse(nums, 0, nums.Length - 1 - k);

            Reverse(nums, nums.Length - k, nums.Length - 1);

            Reverse(nums, 0, nums.Length - 1);
        }
    }
}
