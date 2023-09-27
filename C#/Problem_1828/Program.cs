using System;

namespace Problem_1828
{
    // 1828. Queries on Number of Points Inside a Circle
    // https://leetcode.com/problems/queries-on-number-of-points-inside-a-circle/description/
    internal class Program
    {
        public int[] CountPoints(int[][] points, int[][] queries)
        {
            int[] answer = new int[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                int a = queries[i][0];
                int b = queries[i][1];
                int r = queries[i][2];
                for (int j = 0; j < points.Length; j++)
                {
                    int x = points[j][0];
                    int y = points[j][1];
                    double distance = Math.Sqrt(Math.Pow(x - a, 2) + Math.Pow(y - b, 2));
                    if (distance <= r)
                        answer[i]++;
                }
            }

            return answer;
        }

        static void Main(string[] args)
        {
        }
    }
}
