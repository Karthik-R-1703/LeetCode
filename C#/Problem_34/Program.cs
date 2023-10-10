namespace Problem_34
{
    // 34. Find First and Last Position of Element in Sorted Array
    // https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/description/
    internal class Program
    {
        static void Main(string[] args)
        {
            SearchRange(new int[] { }, 8);
            SearchRange(new int[] { }, 6);
            SearchRange(new int[] { }, 0);
        }

        public static int[] SearchRange(int[] nums, int target)
        {
            int start = -1;
            int end = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    if (start == -1)
                        start = i;

                    end = i;
                }
                else if (end != -1)
                {
                    break;
                }
            }

            return new int[] { start, end };
        }
    }
}
