namespace Problem_867
{
    // 867. Transpose Matrix
    // https://leetcode.com/problems/transpose-matrix/description/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 1, 2, 3 },
                new int[] { 1, 2, 3 }
            };

            Transpose(matrix);
        }

        public static int[][] Transpose(int[][] matrix)
        {
            int rows = matrix.Length;
            int cols = matrix[0].Length;
            int[][] result = new int[cols][];
            for (int i = 0; i < cols; i++)
            {
                result[i] = new int[rows];
                for (int j = 0; j < rows; j++)
                {
                    result[i][j] = matrix[j][i];
                }
            }

            return result;
        }
    }
}
