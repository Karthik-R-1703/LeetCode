using System;

namespace Problem_2285
{
    // 2285. Maximum Total Importance of Roads
    // https://leetcode.com/problems/maximum-total-importance-of-roads/description/
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static long MaximumImportance(int n, int[][] roads)
        {
            long totalImportance = 0;
            int[] path = new int[n];
            foreach (int[] road in roads)
            {
                path[road[0]]++;
                path[road[1]]++;
            }

            Array.Sort(path);
            long importance = 1;
            foreach (int p in path)
            {
                totalImportance += importance * p;
                importance++;
            }

            return totalImportance;
        }
    }
}
