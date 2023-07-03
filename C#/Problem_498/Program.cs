namespace Problem_498
{
    // 498. Diagonal Traverse
    // https://leetcode.com/problems/diagonal-traverse/
    internal class Program
    {
        public static int[] FindDiagonalOrder(int[][] mat)
        {
            int m = mat.Length;
            int n = mat[0].Length;
            int[] DiagonalArray = new int[m * n];

            int i = 0;
            int j = 0;
            int k = 0;
            bool isUp = true;

            while (k < m * n)
            {
                DiagonalArray[k++] = mat[i][j];

                if (isUp)
                {
                    if (i > 0 && j < n - 1)
                    {
                        i--;
                        j++;
                    }
                    else if (j == n - 1)
                    {
                        i++;
                        isUp = false;
                    }
                    else if (i == 0)
                    {
                        j++;
                        isUp = false;
                    }
                }
                else
                {
                    if (j > 0 && i < m - 1)
                    {
                        i++;
                        j--;
                    }
                    else if (i == m - 1)
                    {
                        j++;
                        isUp = true;
                    }
                    else if (j == 0)
                    {
                        i++;
                        isUp = true;
                    }
                }
            }

            return DiagonalArray;
        }

        static void Main(string[] args)
        {
            int[][] mat1 = new int[][] {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 }
            };

            FindDiagonalOrder(mat1);

            int[][] mat2 = new int[][] {
                new int[] { 1, 2 },
                new int[] {3, 4 }
            };

            FindDiagonalOrder(mat2);
        }
    }
}
