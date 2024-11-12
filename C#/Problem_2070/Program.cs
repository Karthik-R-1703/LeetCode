using System;
using System.Collections.Generic;

namespace Problem_2070
{
    // 2070. Most Beautiful Item for Each Query
    // https://leetcode.com/problems/most-beautiful-item-for-each-query/description/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] items1 = new int[][] {
                new int[] { 1, 2 },
                new int[] { 3, 2 },
                new int[] { 2, 4 },
                new int[] { 5, 6 },
                new int[] { 3, 5 }
            };

            MaximumBeauty(items1, new int[] { 6, 1, 2, 3, 4, 5, 6 });

            int[][] items2 = new int[][] {
                new int[] { 1, 2 },
                new int[] { 1, 2 },
                new int[] { 1, 3 },
                new int[] { 1, 4 }
            };

            MaximumBeauty(items2, new int[] { 1 });
        }

        public static int[] MaximumBeauty(int[][] items, int[] queries)
        {
            int[] answer = new int[queries.Length];
            Array.Sort(items, (a, b) => a[0].CompareTo(b[0]));
            int[] new_queries = new int[queries.Length];
            Array.Copy(queries, new_queries, queries.Length);
            Array.Sort(new_queries);
            Dictionary<int, int> new_beauty = new Dictionary<int, int>();
            int k = 0;
            int maxBeauty = 0;
            for (int i = 0; i < new_queries.Length; i++)
            {
                while (k < items.Length && items[k][0] <= new_queries[i])
                {
                    maxBeauty = Math.Max(maxBeauty, items[k][1]);
                    k++;
                }

                new_beauty[new_queries[i]] = maxBeauty;
            }

            for (int i = 0; i < queries.Length; i++)
                answer[i] = new_beauty[queries[i]];

            return answer;
        }
    }
}
