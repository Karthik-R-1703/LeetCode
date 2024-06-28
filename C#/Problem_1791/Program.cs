using System.Collections.Generic;

namespace Problem_1791
{
    // 1791. Find Center of Star Graph
    // https://leetcode.com/problems/find-center-of-star-graph/description/
    internal class Program
    {
        public static int FindCenter(int[][] edges)
        {
            HashSet<int> v = new HashSet<int>();
            for (int i = 0; i < edges.Length; i++)
            {
                if (v.Contains(edges[i][0]))
                    return edges[i][0];
                else
                    v.Add(edges[i][0]);

                if (v.Contains(edges[i][1]))
                    return edges[i][1];
                else
                    v.Add(edges[i][1]);
            }

            return 0;
        }

        static void Main(string[] args)
        {
        }
    }
}
