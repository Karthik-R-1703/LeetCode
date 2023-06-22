namespace Problem_238
{
    // 238. Product of Array Except Self
    // https://leetcode.com/problems/product-of-array-except-self/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 4 };
            ProductExceptSelf(nums1);

            int[] nums2 = { -1, 1, 0, -3, 3 };
            ProductExceptSelf(nums2);
        }

        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] product = new int[nums.Length];

            int temp = 1;
            int contains_zero = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    temp *= nums[i];
                }
                else
                {
                    contains_zero++;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (contains_zero > 1)
                {
                    product[i] = 0;
                }
                else if (contains_zero == 1)
                {
                    if (nums[i] == 0)
                    {
                        product[i] = temp;
                    }
                    else
                    {
                        product[i] = 0;
                    }
                }
                else
                {
                    product[i] = temp / nums[i];
                }
            }

            return product;
        }
    }
}
