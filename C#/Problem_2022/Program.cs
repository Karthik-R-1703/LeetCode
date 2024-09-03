namespace Problem_2022
{
    // 2022. Convert 1D Array Into 2D Array
    // https://leetcode.com/problems/convert-1d-array-into-2d-array/description/
    internal class Program
    {
        public static int[][] Construct2DArray(int[] original, int m, int n)
        {
            int[][] result = new int[m][];
            if (m * n != original.Length)
                return new int[0][];

            for (int i = 0; i < m; i++)
                result[i] = new int[n];

            int k = 0;
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    result[i][j] = original[k++];

            return result;
        }

        static void Main(string[] args)
        {
        }
    }
}
