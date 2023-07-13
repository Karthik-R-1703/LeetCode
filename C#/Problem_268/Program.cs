namespace Problem_268
{
    // 268. Missing Number
    // https://leetcode.com/problems/missing-number/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 3, 0, 1 };
            MissingNumber(nums1);

            int[] nums2 = { 0, 1 };
            MissingNumber(nums2);

            int[] nums3 = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
            MissingNumber(nums3);
        }

        public static int MissingNumber(int[] nums)
        {
            int n = nums.Length;
            int expected_sum = (n * (n + 1)) / 2;
            int sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }

            return expected_sum - sum;
        }
    }
}
