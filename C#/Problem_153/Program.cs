namespace Problem_153
{
    // 153. Find Minimum in Rotated Sorted Array
    // https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/description/
    internal class Program
    {
        public static int FindMin(int[] nums)
        {
            int start = 0;
            int end = nums.Length - 1;

            while (start < end)
            {
                int index = (start + end) / 2;

                if (nums[index] > nums[end])
                {
                    start = index + 1;
                }
                else
                {
                    end = index;
                }
            }

            return nums[start];
        }

        static void Main(string[] args)
        {
            FindMin(new int[] { 3, 4, 5, 1, 2 });
            FindMin(new int[] { 4, 5, 6, 7, 0, 1, 2 });
            FindMin(new int[] { 11, 13, 15, 17 });
        }
    }
}
