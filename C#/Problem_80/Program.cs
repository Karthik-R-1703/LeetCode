namespace Problem_80
{
    // 80. Remove Duplicates from Sorted Array II
    // https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 1, 1, 2, 2, 3 };
            RemoveDuplicates(nums1);

            int[] nums2 = { 0, 0, 1, 1, 1, 1, 2, 3, 3 };
            RemoveDuplicates(nums2);
        }

        public static int RemoveDuplicates(int[] nums)
        {
            int left = 0, right = 1, count = 1;
            while (right < nums.Length)
            {
                if (nums[left] != nums[right])
                {
                    nums[left + right] = nums[right];
                    count = 1;
                }
                else if (nums[left] == nums[right] && count < 2)
                {
                    nums[left + right] = nums[right];
                    count++;
                }

                right++;
            }

            return left + 1;
        }
    }
}
