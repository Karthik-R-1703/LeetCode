namespace Problem_496
{
    // 496. Next Greater Element I
    // https://leetcode.com/problems/next-greater-element-i/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1_1 = { 4, 1, 2 };
            int[] nums1_2 = { 1, 3, 4, 2 };
            NextGreaterElement(nums1_1, nums1_2);

            int[] nums2_1 = { 2, 4 };
            int[] nums2_2 = { 1, 2, 3, 4 };
            NextGreaterElement(nums2_1, nums2_2);
        }

        public static int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            int[] result = new int[nums1.Length];
            for (int n = 0; n < nums1.Length; n++)
            {
                int max = int.MinValue;
                int i = 0;
                for (i = nums2.Length - 1; i >= 0; i--)
                {
                    if (nums2[i] == nums1[n])
                        break;

                    if (nums2[i] > max)
                        max = nums2[i];
                }

                if (max == int.MinValue)
                    result[n] = -1;
                else if (max > nums1[n])
                    result[n] = i;
                else
                    result[n] = -1;
            }

            return result;
        }
    }
}
