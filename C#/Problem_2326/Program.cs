using LeetCode;

namespace Problem_2326
{
    // 2326. Spiral Matrix IV
    // https://leetcode.com/problems/spiral-matrix-iv/description/
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public int[][] SpiralMatrix(int m, int n, ListNode head)
        {
            int[][] matrix = new int[m][];
            for (int i = 0; i < m; i++)
            {
                matrix[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    matrix[i][j] = -1;
                }
            }

            int top = 0, bottom = m, left = 0, right = n;
            while (head != null)
            {
                for (int i = left; i < right && head != null; i++)
                {
                    matrix[top][i] = head.val;
                    head = head.next;
                }

                top++;
                for (int i = top; i < bottom && head != null; i++)
                {
                    matrix[i][right - 1] = head.val;
                    head = head.next;
                }

                right--;
                for (int i = right - 1; i >= left && head != null; i--)
                {
                    matrix[bottom - 1][i] = head.val;
                    head = head.next;
                }

                bottom--;
                for (int i = bottom - 1; i >= top && head != null; i--)
                {
                    matrix[i][left] = head.val;
                    head = head.next;
                }

                left++;
            }

            return matrix;
        }
    }
}
