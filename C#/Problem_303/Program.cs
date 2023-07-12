namespace Problem_303
{
    public class NumArray
    {
        public int[] numbers;

        public NumArray(int[] nums)
        {
            numbers = nums;
        }

        public int SumRange(int left, int right)
        {
            int sum = 0;

            for (int i = left; i <= right; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }
    }

    /**
     * Your NumArray object will be instantiated and called as such:
     * NumArray obj = new NumArray(nums);
     * int param_1 = obj.SumRange(left,right);
     */

    // 303. Range Sum Query - Immutable
    // https://leetcode.com/problems/range-sum-query-immutable/
    internal class Program
    {
        static void Main(string[] args)
        {
            NumArray numArray = new NumArray(new int[] { -2, 0, 3, -5, 2, -1 });
            numArray.SumRange(0, 2); // return (-2) + 0 + 3 = 1
            numArray.SumRange(2, 5); // return 3 + (-5) + 2 + (-1) = -1
            numArray.SumRange(0, 5); // return (-2) + 0 + 3 + (-5) + 2 + (-1) = -3
        }
    }
}
