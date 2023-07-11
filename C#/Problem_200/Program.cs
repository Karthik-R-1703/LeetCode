using System.Collections.Generic;

namespace Problem_200
{
    // 200. Number of Islands
    // https://leetcode.com/problems/number-of-islands/
    internal class Program
    {
        static void Main(string[] args)
        {
            char[][] grid1 = new char[][]
            {
                new char[] { '1', '1', '1', '1', '0' },
                new char[] { '1', '1', '0', '1', '0' },
                new char[] { '1', '1', '0', '0', '0' },
                new char[] { '0', '0', '0', '0', '0' }
            };

            NumIslands(grid1);

            char[][] grid2 = new char[][]
            {
                new char[] { '1', '1', '0', '0', '0' },
                new char[] { '1', '1', '0', '0', '0' },
                new char[] { '0', '0', '1', '0', '0' },
                new char[] { '0', '0', '0', '1', '1' }
            };

            NumIslands(grid2);
        }

        public static int NumIslands(char[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            int count = 0;

            Queue<int[]> queue = new Queue<int[]>();

            bool[][] visited = new bool[m][];
            for (int i = 0; i < m; i++)
            {
                visited[i] = new bool[n];
            }

            int[][] directions = new int[][]
            {
                new int[] {-1, 0}, // up
                new int[] {1, 0},  // down
                new int[] {0, -1}, // left
                new int[] {0, 1}   // right
            };

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == '1' && !visited[i][j])
                    {
                        count++;
                        queue.Enqueue(new int[] { i, j });
                        visited[i][j] = true;

                        while (queue.Count > 0)
                        {
                            int[] curr = queue.Dequeue();
                            int currRow = curr[0];
                            int currCol = curr[1];

                            for (int k = 0; k < directions.Length; k++)
                            {
                                int newRow = currRow + directions[k][0];
                                int newCol = currCol + directions[k][1];

                                if (newRow >= 0 && newRow < m && newCol >= 0 && newCol < n && grid[newRow][newCol] == '1' && !visited[newRow][newCol])
                                {
                                    queue.Enqueue(new int[] { newRow, newCol });
                                    visited[newRow][newCol] = true;
                                }
                            }
                        }
                    }
                }
            }

            return count;
        }
    }
}
