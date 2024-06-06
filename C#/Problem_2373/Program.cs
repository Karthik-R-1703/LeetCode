using System;

namespace Problem_2373
{
    // 2373. Largest Local Values in a Matrix
    // https://leetcode.com/problems/largest-local-values-in-a-matrix/description/
    internal class Program
    {
        private static int FindMax(int[][] grid, int x, int y)
        {
            int maxElement = 0;
            for (int i = x; i < x + 3; i++)
            {
                for (int j = y; j < y + 3; j++)
                {
                    maxElement = Math.Max(maxElement, grid[i][j]);
                }
            }

            return maxElement;
        }

        public static int[][] LargestLocal(int[][] grid)
        {
            int N = grid[0].Length;
            int[][] maxLocal = new int[N - 2][];
            for (int i = 0; i < N - 2; i++)
            {
                maxLocal[i] = new int[N - 2];
            }

            for (int i = 0; i < N - 2; i++)
            {
                for (int j = 0; j < N - 2; j++)
                {
                    maxLocal[i][j] = FindMax(grid, i, j);
                }
            }

            return maxLocal;
        }

        static void Main(string[] args)
        {
        }
    }
}
