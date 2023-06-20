namespace Problem_2090
{
    // 2090. K Radius Subarray Averages
    // https://leetcode.com/problems/k-radius-subarray-averages/
    internal class Program
    {
        public static int[] GetAverages(int[] nums, int k)
        {
            int n = nums.Length;
            int[] avgs = new int[n];

            for (int i = 0; i < n; i++)
            {
                if (i - k < 0 || i + k >= n)
                {
                    avgs[i] = -1;
                }
                else
                {
                    long sum = 0;
                    for (int j = i - k; j <= i + k; j++)
                    {
                        sum += nums[j];
                    }

                    avgs[i] = (int)(sum / (2 * k + 1));
                }
            }

            return avgs;
        }

        static void Main(string[] args)
        {
            int[] nums = { 7, 4, 3, 9, 1, 8, 5, 2, 6 };
            int[] exp = { -1, -1, -1, 5, 4, 4, -1, -1, -1 };
            int[] act = GetAverages(nums, 3);
        }
    }
}