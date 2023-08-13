namespace Problem_503
{
    // 503. Next Greater Element II
    // https://leetcode.com/problems/next-greater-element-ii/
    internal class Program
    {
        static void Main(string[] args)
        {
            NextGreaterElements(new int[] { 1, 2, 1 });
            NextGreaterElements(new int[] { 1, 2, 3, 4, 3 });
        }

        public static int[] NextGreaterElements(int[] nums)
        {
            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                int max = nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] > max)
                    {
                        max = nums[j];
                        break;
                    }
                }

                if (max == nums[i])
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (nums[j] > max)
                        {
                            max = nums[j];
                            break;
                        }
                    }
                }

                if (max == nums[i])
                {
                    result[i] = -1;
                }
                else
                {
                    result[i] = max;
                }
            }

            return result;
        }
    }
}
