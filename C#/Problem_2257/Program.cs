namespace Problem_2257
{
    // 2257. Count Unguarded Cells in the Grid
    // https://leetcode.com/problems/count-unguarded-cells-in-the-grid/description/
    internal class Program
    {
        static int[][] direction = new int[][]
        {
            new int[] { -1, 0 },
            new int[] { 1, 0 },
            new int[] { 0, -1 },
            new int[] { 0, 1}
        };

        public static int CountUnguarded(int m, int n, int[][] guards, int[][] walls)
        {
            int count = m * n;
            int[][] grid = new int[m][];
            for (int i = 0; i < m; i++)
                grid[i] = new int[n];

            for (int i = 0; i < walls.Length; i++)
            {
                int x = walls[i][0];
                int y = walls[i][1];
                grid[x][y] = 1;
                count--;
            }

            for (int i = 0; i < guards.Length; i++)
            {
                int x = guards[i][0];
                int y = guards[i][1];
                grid[x][y] = 2;
                count--;
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == 2)
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            int px = i + direction[k][0];
                            int py = j + direction[k][1];
                            while (px >= 0 && px < m && py >= 0 && py < n)
                            {
                                if (grid[px][py] == 1 || grid[px][py] == 2)
                                    break;
                                else if (grid[px][py] == 0)
                                {
                                    grid[px][py] = 3;
                                    count--;
                                }

                                px += direction[k][0];
                                py += direction[k][1];
                            }
                        }
                    }
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            int[][] guards1 = new int[][]
            {
                new int[] { 0, 0 },
                new int[] { 1, 1 },
                new int[] { 2, 3 }
            };

            int[][] walls1 = new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 2, 2 },
                new int[] { 1, 4 }
            };

            CountUnguarded(4, 6, guards1, walls1);
        }
    }
}