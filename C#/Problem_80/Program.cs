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

            int[] nums3 = { 1 };
            RemoveDuplicates(nums3);
        }

        public static int RemoveDuplicates(int[] nums)
        {
            int n = nums.Length;

            if (n <= 2)
                return n;

            int left = 2;

            for (int right = 2; right < n; right++)
            {
                if (nums[left - 2] != nums[right])
                {
                    nums[left] = nums[right];
                    left++;
                }
            }

            return left;
        }
    }
}
