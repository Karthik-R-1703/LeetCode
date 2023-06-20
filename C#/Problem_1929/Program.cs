namespace Problem_1929
{
    // 1929. Concatenation of Array
    // https://leetcode.com/problems/concatenation-of-array/
    internal class Program
    {
        public int[] GetConcatenation(int[] nums)
        {
            int[] result = new int[2 * nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = nums[i];
                result[i + nums.Length] = nums[i];
            }

            return result;
        }

        static void Main(string[] args)
        {
        }
    }
}
