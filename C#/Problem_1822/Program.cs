namespace Problem_1822
{
    // 1822. Sign of the Product of an Array
    // https://leetcode.com/problems/sign-of-the-product-of-an-array/
    internal class Program
    {
        public int ArraySign(int[] nums)
        {
            int count = 0;
            foreach (int num in nums)
            {
                if (num == 0)
                {
                    return 0;
                }

                if (num < 0)
                {
                    count++;
                }
            }

            if (count % 2 == 0)
                return 1;
            else
                return -1;
        }

        static void Main(string[] args)
        {
        }
    }
}
