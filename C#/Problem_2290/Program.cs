using System.Collections.Generic;

namespace Problem_2290
{
    // 2290. Minimum Obstacle Removal to Reach Corner
    // https://leetcode.com/problems/minimum-obstacle-removal-to-reach-corner/description/
    internal class Program
    {
        private static int[,] directions = {
            { 0, 1 },
            { 0, -1 },
            { 1, 0 },
            { -1, 0 },
        };

        static void Main(string[] args)
        {
            int[][] grid1 = new int[][]
            {
                new int[] { 0, 1, 1 },
                new int[] { 1, 1, 0 },
                new int[] { 1, 1, 0 }
            };

            MinimumObstacles(grid1);
        }

        public static int MinimumObstacles(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            int[,] minObstacles = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    minObstacles[i, j] = int.MaxValue;
                }
            }

            minObstacles[0, 0] = 0;
            Queue<(int, int, int)> zeroQueue = new Queue<(int, int, int)>();
            zeroQueue.Enqueue((0, 0, 0));

            Queue<(int, int, int)> oneQueue = new Queue<(int, int, int)>();

            while (zeroQueue.Count > 0 || oneQueue.Count > 0)
            {
                while (zeroQueue.Count > 0)
                {
                    List<Queue<(int, int, int)>> lists = Obstacles(grid, minObstacles, zeroQueue);
                    zeroQueue = lists[0];
                    oneQueue = lists[1];
                }

                while (oneQueue.Count > 0)
                {
                    List<Queue<(int, int, int)>> lists = Obstacles(grid, minObstacles, oneQueue);
                    zeroQueue = lists[0];
                    oneQueue = lists[1];
                }
            }

            return minObstacles[m - 1, n - 1];
        }

        private static List<Queue<(int, int, int)>> Obstacles(int[][] grid, int[,] minObstacles, Queue<(int, int, int)> curQueue)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            Queue<(int, int, int)> zeroQueue = new Queue<(int, int, int)>();
            Queue<(int, int, int)> oneQueue = new Queue<(int, int, int)>();
            while (curQueue.Count > 0)
            {
                (int obstacles, int row, int col) value = curQueue.Dequeue();
                for (int i = 0; i < 4; i++)
                {
                    int newRow = value.row + directions[i, 0];
                    int newCol = value.col + directions[i, 1];
                    if (newRow >= 0 && newCol >= 0 && newRow < m && newCol < n)
                    {
                        if (minObstacles[newRow, newCol] == int.MaxValue)
                        {
                            if (grid[newRow][newCol] == 1)
                            {
                                minObstacles[newRow, newCol] = value.obstacles + 1;
                                oneQueue.Enqueue((value.obstacles + 1, newRow, newCol));
                            }
                            else
                            {
                                minObstacles[newRow, newCol] = value.obstacles;
                                zeroQueue.Enqueue((value.obstacles, newRow, newCol));
                            }
                        }
                    }
                }
            }

            List<Queue<(int, int, int)>> lists = new List<Queue<(int, int, int)>>
            {
                zeroQueue,
                oneQueue
            };

            return lists;
        }
    }
}
