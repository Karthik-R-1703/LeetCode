using System.Collections.Generic;

namespace Problem_54
{
    // 54. Spiral Matrix
    // https://leetcode.com/problems/spiral-matrix/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] mat1 = new int[][] {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 }
            };

            SpiralOrder(mat1);

            int[][] mat2 = new int[][] {
                new int[] { 1, 2,3,4 },
                new int[] {5,6,7,8 },
                new int[] { 9,10,11,12 }
            };

            SpiralOrder(mat2);
        }

        public static IList<int> SpiralOrder(int[][] matrix)
        {
            List<int> SpiralMatrix = new List<int>();
            int m = matrix.Length;
            int n = matrix[0].Length;
            int i = 0;
            int j = 0;
            int k = 0;
            int right = n - 1;
            int down = m - 1;
            int left = 0;
            int up = 0;

            int direction = 0;

            while (k < m * n)
            {
                SpiralMatrix.Add(matrix[i][j]);
                if (direction == 0) // Right
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
                else if (direction == 1) // Down
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
                else if (direction == 2) // Left
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
                else // Up
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
