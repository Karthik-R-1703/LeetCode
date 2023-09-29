namespace Problem_896
{
    // 896. Monotonic Array
    // https://leetcode.com/problems/monotonic-array/description/
    internal class Program
    {
        public static bool IsMonotonic(int[] nums)
        {
            if (nums.Length == 1)
                return true;

            int i = 0;
            for (i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                    break;
            }

            if (nums.Length - 1 == i)
                return true;

            for (i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] < nums[i + 1])
                    break;
            }

            if (nums.Length - 1 == i)
                return true;

            return false;
        }

        static void Main(string[] args)
        {
            IsMonotonic(new int[] { 1, 2, 2, 3 });
            IsMonotonic(new int[] { 6, 5, 4, 4 });
            IsMonotonic(new int[] { 1, 3, 2 });
        }
    }
}
