namespace Problem_1909
{
    // 1909. Remove One Element to Make the Array Strictly Increasing
    // https://leetcode.com/problems/remove-one-element-to-make-the-array-strictly-increasing/description/
    internal class Program
    {
        public static bool CanBeIncreasing(int[] nums)
        {
            bool isFirst = false;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] >= nums[i + 1])
                {
                    if (isFirst)
                        return false;
                    else
                        isFirst = true;

                    if (i > 0 && i + 1 < nums.Length && nums[i - 1] >= nums[i + 1])
                    {
                        nums[i + 1] = nums[i];
                    }
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            CanBeIncreasing(new int[] { 1, 2, 10, 5, 7 });
            CanBeIncreasing(new int[] { 2, 3, 1, 2 });
            CanBeIncreasing(new int[] { 1, 1, 1 });
        }
    }
}
