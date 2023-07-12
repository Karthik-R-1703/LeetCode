namespace Problem_1480
{
    // 1480. Running Sum of 1d Array
    // https://leetcode.com/problems/running-sum-of-1d-array/
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public int[] RunningSum(int[] nums)
        {
            int[] runningSum = new int[nums.Length];
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                runningSum[i] = sum;
            }

            return runningSum;
        }
    }
}
