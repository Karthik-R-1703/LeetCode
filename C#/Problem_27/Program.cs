namespace Problem_27
{
    // 27. Remove Element
    // https://leetcode.com/problems/remove-element/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 3, 2, 2, 3 };
            RemoveElement(nums1, 3);

            int[] nums2 = { 0, 1, 2, 2, 3, 0, 4, 2 };
            RemoveElement(nums2, 2);
        }

        public static int RemoveElement(int[] nums, int val)
        {
            int left = 0;
            int right = 0;
            while (right < nums.Length)
            {
                if (nums[right] != val)
                {
                    nums[left] = nums[right];
                    left++;
                }

                right++;
            }

            return left;
        }
    }
}
