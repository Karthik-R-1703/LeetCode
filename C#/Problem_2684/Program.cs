using System;
using System.Collections.Generic;

namespace Problem_2684
{
    // 2684. Maximum Number of Moves in a Grid
    // https://leetcode.com/problems/maximum-number-of-moves-in-a-grid/description/
    internal class Program
    {
        private static int[] pos = new int[] { -1, 0, 1 };

        static void Main(string[] args)
        {
        }

        public static int MaxMoves(int[][] grid)
        {
            int maxMoves = int.MinValue;
            int m = grid.Length;
            int n = grid[0].Length;
            int[][] visited = new int[m][];
            for (int i = 0; i < m; i++)
                visited[i] = new int[n];

            Queue<int[]> queue = new Queue<int[]>();
            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(new int[] { i, 0, 0 });
                visited[i][0] = 1;
            }

            while (queue.Count > 0)
            {
                int[] ints = queue.Dequeue();
                int x = ints[0];
                int y = ints[1];
                int count = ints[2];
                maxMoves = Math.Max(maxMoves, count);
                foreach (int p in pos)
                {
                    int i = x + p;
                    int j = y + 1;
                    if (i >= 0 && j >= 0 && i < m && j < n && visited[i][j] == 0 && grid[x][y] < grid[i][j])
                    {
                        visited[i][j] = 1;
                        queue.Enqueue(new int[] { i, j, count + 1 });
                    }
                }
            }

            return maxMoves;
        }
    }
}
