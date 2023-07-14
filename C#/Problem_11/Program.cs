using System;

namespace Problem_11
{
    // 11. Container With Most Water
    // https://leetcode.com/problems/container-with-most-water/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] height1 = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            MaxArea(height1);

            int[] height2 = { 1, 1 };
            MaxArea(height2);
        }

        public static int MaxArea(int[] height)
        {
            int n = height.Length;
            int maxArea = 0;
            int left = 0;
            int right = n - 1;

            while (left < right)
            {
                int currentArea = Math.Min(height[left], height[right]) * (right - left);
                maxArea = Math.Max(maxArea, currentArea);

                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return maxArea;
        }
    }
}
