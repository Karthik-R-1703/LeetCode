using System.Collections.Generic;

namespace Problem_733
{
    // 733. Flood Fill
    // https://leetcode.com/problems/flood-fill/description/
    internal class Program
    {
        public static int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            int srcColor = image[sr][sc];
            int m = image.Length;
            int n = image[sr].Length;
            Stack<(int, int)> StackList = new Stack<(int, int)>();
            Stack<(int, int)> VisitedList = new Stack<(int, int)>();
            StackList.Push((sr, sc));
            while (StackList.Count > 0)
            {
                (int i, int j) = StackList.Pop();

                if (VisitedList.Contains((i, j)))
                {
                    continue;
                }

                if (image[i][j] == srcColor)
                {
                    image[i][j] = color;

                    if (i - 1 >= 0 && i - 1 < m && j >= 0 && j < n && image[i - 1][j] == srcColor)
                        StackList.Push((i - 1, j));

                    if (i >= 0 && i < m && j - 1 >= 0 && j - 1 < n && image[i][j - 1] == srcColor)
                        StackList.Push((i, j - 1));

                    if (i >= 0 && i < m && j + 1 >= 0 && j + 1 < n && image[i][j + 1] == srcColor)
                        StackList.Push((i, j + 1));

                    if (i + 1 >= 0 && i + 1 < m && j >= 0 && j < n && image[i + 1][j] == srcColor)
                        StackList.Push((i + 1, j));
                }

                VisitedList.Push((i, j));
            }

            return image;
        }

        static void Main(string[] args)
        {
            int[][] image1 = {
                new int[] { 1, 1, 1 },
                new int[] { 1, 1, 0 },
                new int[] { 1, 0, 1 }
            };

            image1 = FloodFill(image1, 1, 1, 2);

            int[][] image2 = {
                new int[] { 0, 0, 0 },
                new int[] { 0, 0, 0 }
            };

            image2 = FloodFill(image2, 0, 0, 0);
        }
    }
}
