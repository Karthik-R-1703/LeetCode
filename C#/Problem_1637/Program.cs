using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1637
{
    // 1637. Widest Vertical Area Between Two Points Containing No Points
    // https://leetcode.com/problems/widest-vertical-area-between-two-points-containing-no-points/description/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] points1 = new int[4][]
            {
                new int[] { 8, 7 },
                new int[] { 9, 9 },
                new int[] { 7, 4 },
                new int[] { 9, 7 }
            };

            MaxWidthOfVerticalArea(points1);
        }

        public static int MaxWidthOfVerticalArea(int[][] points)
        {
            int MaxWidth = 0;
            HashSet<int> t_x = new HashSet<int>();
            for (int i = 0; i < points.Length; i++)
            {
                t_x.Add(points[i][0]);
            }

            int[] x = t_x.ToArray();
            Array.Sort(x);

            for (int i = 0; i < x.Length - 1; i++)
            {
                int Width = x.ElementAt(i + 1) - x.ElementAt(i);
                if (Width > MaxWidth)
                {
                    MaxWidth = Width;
                }
            }

            GC.Collect();
            return MaxWidth;
        }
    }
}
