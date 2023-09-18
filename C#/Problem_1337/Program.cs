using System.Collections.Generic;

namespace Problem_1337
{
    // 1337. The K Weakest Rows in a Matrix
    // https://leetcode.com/problems/the-k-weakest-rows-in-a-matrix/
    internal class Program
    {
        public static int[] KWeakestRows(int[][] mat, int k)
        {
            List<int> result = new List<int>(k);
            Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();

            for (int i = 0; i < mat.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < mat[i].Length; j++)
                {
                    count += mat[i][j];
                }

                if (map.ContainsKey(count))
                {
                    map[count].Add(i);
                }
                else
                    map.Add(count, new List<int> { i });
            }

            for (int i = 0; i <= mat[0].Length; i++)
            {
                if (map.ContainsKey(i))
                {
                    int count = map[i].Count;
                    if (count <= k)
                    {
                        result.AddRange(map[i]);
                        k -= count;
                    }
                    else
                    {
                        for (int j = 0; j < mat[0].Length && j < k; j++)
                        {
                            result.Add(map[i][j]);
                        }

                        k = 0;
                    }
                }

                if (k == 0)
                    break;
            }

            return result.ToArray();
        }

        static void Main(string[] args)
        {
            int[][] mat1 = new int[][]
            {
                new int[] {1, 1, 0, 0, 0},
                new int[] {1, 1, 1, 1, 0},
                new int[] {1, 0, 0, 0, 0},
                new int[] {1, 1, 0, 0, 0},
                new int[] {1, 1, 1, 1, 1}
            };

            int[] result1 = KWeakestRows(mat1, 3);

            int[][] mat2 = new int[][]
            {
                new int[] {1, 0, 0, 0},
                new int[] {1, 1, 1, 1},
                new int[] {1, 0, 0, 0},
                new int[] {1, 0, 0, 0}
            };

            int[] result2 = KWeakestRows(mat2, 2);

            int[][] mat3 = new int[][]
            {
                new int[] {1, 1, 1, 1, 1, 1},
                new int[] {1, 1, 1, 1, 1, 1},
                new int[] {1, 1, 1, 1, 1, 1}
            };

            int[] result3 = KWeakestRows(mat3, 1);
        }
    }
}
