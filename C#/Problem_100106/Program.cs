namespace Problem_100106
{
    // 100106. Minimum Sum of Mountain Triplets I
    // 2908. Minimum Sum of Mountain Triplets I
    // https://leetcode.com/problems/minimum-sum-of-mountain-triplets-i/description/
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static int MinimumSum(int[] nums)
        {
            int minSum = int.MaxValue;
            for (int i = 0; i < nums.Length - 2; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if (nums[i] < nums[j] && nums[k] < nums[j])
                        {
                            int sum = nums[i] + nums[j] + nums[k];
                            if (sum < minSum)
                                minSum = sum;
                        }
                    }
                }
            }

            if (minSum == int.MaxValue)
                return -1;

            return minSum;
        }
    }
}
