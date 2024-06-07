namespace Problem_463
{
    // 463. Island Perimeter
    // https://leetcode.com/problems/island-perimeter/description/
    internal class Program
    {
        public int IslandPerimeter(int[][] grid)
        {
            int Perimeter = 0;
            int m = grid.Length;
            int n = grid[0].Length;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        Perimeter += 4;

                        if (i >= 1 && grid[i - 1][j] == 1)
                            Perimeter--;

                        if (i + 1 < m && grid[i + 1][j] == 1)
                            Perimeter--;

                        if (j >= 1 && grid[i][j - 1] == 1)
                            Perimeter--;

                        if (j + 1 < n && grid[i][j + 1] == 1)
                            Perimeter--;
                    }
                }
            }

            return Perimeter;
        }

        static void Main(string[] args)
        {
        }
    }
}
