using System.Collections.Generic;

namespace Problem_695
{
    // 695. Max Area of Island
    // https://leetcode.com/problems/max-area-of-island/description/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] grid_1 = {
                new int[] { 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 },
                new int[] { 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int[] { 0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0 },
                new int[] { 0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0 }
            };

            MaxAreaOfIsland(grid_1);
        }

        public static int MaxAreaOfIsland(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            int Area = 0;
            int MaxArea = 0;
            Queue<(int, int)> queue = new Queue<(int, int)>();

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
                    if (grid[i][j] == 1 && !visited[i][j])
                    {
                        Area = 0;
                        queue.Enqueue((i, j));
                        visited[i][j] = true;
                        while (queue.Count > 0)
                        {
                            Area++;
                            (int currRow, int currCol) = queue.Dequeue();
                            for (int k = 0; k < directions.Length; k++)
                            {
                                int newRow = currRow + directions[k][0];
                                int newCol = currCol + directions[k][1];

                                if (newRow >= 0 && newRow < m && newCol >= 0 && newCol < n && grid[newRow][newCol] == 1 && !visited[newRow][newCol])
                                {
                                    queue.Enqueue((newRow, newCol));
                                    visited[newRow][newCol] = true;
                                }
                            }
                        }

                        if (Area > MaxArea)
                            MaxArea = Area;
                    }
                }
            }

            return MaxArea;
        }
    }
}
