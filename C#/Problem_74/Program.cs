namespace Problem_74
{
    // 74. Search a 2D Matrix
    // https://leetcode.com/problems/search-a-2d-matrix/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix_1 = new int[][] {
                new int[] { 1, 3, 5, 7 },
                new int[] { 10, 11, 16, 20 },
                new int[] { 23, 30, 34, 60 }
            };

            SearchMatrix(matrix_1, 3);
            SearchMatrix(matrix_1, 13);
        }

        public static bool SearchMatrix(int[][] matrix, int target)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            int left = 0;
            int right = (m * n) - 1;

            while (left <= right)
            {
                int i = left + (right - left) / 2;
                int temp = matrix[i / n][i % n];

                if (temp == target)
                    return true;
                else if (temp < target)
                    left = i + 1;
                else
                    right = i - 1;
            }

            return false;
        }
    }
}
