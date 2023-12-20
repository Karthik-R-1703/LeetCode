namespace Problem_59
{
    // 59. Spiral Matrix II
    // https://leetcode.com/problems/spiral-matrix-ii/description/
    internal class Program
    {
        static void Main(string[] args)
        {
            GenerateMatrix(3);
        }

        public static int[][] GenerateMatrix(int n)
        {
            int[][] SpiralMatrix = new int[n][];
            for (int x = 0; x < n; x++)
                SpiralMatrix[x] = new int[n];

            int i = 0;
            int j = 0;
            int k = 0;
            int right = n - 1;
            int down = n - 1;
            int left = 0;
            int up = 0;

            int direction = 0;

            while (k < n * n)
            {
                SpiralMatrix[i][j] = k + 1;
                if (direction == 0)
                {
                    if (j == right)
                    {
                        i++;
                        direction = 1;
                        up++;
                    }
                    else
                        j++;
                }
                else if (direction == 1)
                {
                    if (i == down)
                    {
                        j--;
                        direction = 2;
                        right--;
                    }
                    else
                        i++;
                }
                else if (direction == 2)
                {
                    if (j == left)
                    {
                        i--;
                        direction = 3;
                        down--;
                    }
                    else
                        j--;
                }
                else
                {
                    if (i == up)
                    {
                        j++;
                        direction = 0;
                        left++;
                    }
                    else
                        i--;
                }

                k++;
            }

            return SpiralMatrix;
        }
    }
}
