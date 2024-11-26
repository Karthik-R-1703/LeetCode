using System.Collections.Generic;
using System.Linq;

namespace Problem_2924
{
    // 2924. Find Champion II
    // https://leetcode.com/problems/find-champion-ii/description/
    internal class Program
    {
        public int FindChampion(int n, int[][] edges)
        {
            HashSet<int> teams = new HashSet<int>();
            for (int i = 0; i < n; i++)
                teams.Add(i);

            for (int i = 0; i < edges.Length; i++)
                if (teams.Contains(edges[i][1]))
                    teams.Remove(edges[i][1]);

            if (teams.Count > 1)
                return -1;
            else
                return teams.ElementAt(0);
        }

        static void Main(string[] args)
        {
        }
    }
}
