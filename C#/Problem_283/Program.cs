namespace Problem_283
{
    // 283. Move Zeroes
    // https://leetcode.com/problems/move-zeroes/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 0, 1, 0, 3, 12 };
            MoveZeroes(nums1);

            int[] nums2 = { 0 };
            MoveZeroes(nums2);
        }

        public static void MoveZeroes(int[] nums)
        {
            int left = 0;
            int right = 0;
            while (right < nums.Length)
            {
                if (nums[right] != 0)
                {
                    nums[left] = nums[right];
                    left++;
                }

                right++;
            }

            while (left < nums.Length)
            {
                nums[left++] = 0;
            }
        }
    }
}
