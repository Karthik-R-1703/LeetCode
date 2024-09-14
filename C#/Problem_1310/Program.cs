namespace Problem_1310
{
    // 1310. XOR Queries of a Subarray
    // https://leetcode.com/problems/xor-queries-of-a-subarray/description/
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static int[] XorQueries(int[] arr, int[][] queries)
        {
            int[] answer = new int[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                int xorSum = 0;
                for (int j = queries[i][0]; j <= queries[i][1]; j++)
                    xorSum ^= arr[j];

                answer[i] = xorSum;
            }

            return answer;
        }
    }
}
