namespace Problem_33
{
    // 33. Search in Rotated Sorted Array
    // https://leetcode.com/problems/search-in-rotated-sorted-array/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums_1 = { 4, 5, 6, 7, 0, 1, 2 };
            Search(nums_1, 0);
            Search(nums_1, 3);

            int[] nums_2 = { 1 };
            Search(nums_2, 0);
        }

        public static int Search(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;

            while (start <= end)
            {
                int index = (start + end) / 2;

                if (nums[index] == target)
                {
                    return index;
                }
                else if (nums[start] <= nums[index])
                {
                    if (nums[start] <= target && target < nums[index])
                    {
                        end = index - 1;
                    }
                    else
                    {
                        start = index + 1;
                    }
                }
                else
                {
                    if (target <= nums[end] && target > nums[index])
                    {
                        start = index + 1;
                    }
                    else
                    {
                        end = index - 1;
                    }
                }
            }

            return -1;
        }
    }
}
