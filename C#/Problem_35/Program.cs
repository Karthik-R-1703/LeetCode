namespace Problem_35
{
    // 35. Search Insert Position
    // https://leetcode.com/problems/search-insert-position/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 5, 6 };

            SearchInsert(nums, 5);
            SearchInsert(nums, 2);
            SearchInsert(nums, 7);
        }

        public static int SearchInsert(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;
            int index = (start + end) / 2;

            while (start <= end)
            {
                if (nums[index] == target)
                {
                    return index;
                }
                else if (nums[index] < target)
                {
                    start = index + 1;
                    index = (start + end) / 2;
                }
                else
                {
                    end = index - 1;
                    index = (start + end) / 2;
                }
            }

            return start;
        }
    }
}
