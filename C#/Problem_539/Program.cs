using System;
using System.Collections.Generic;

namespace Problem_539
{
    // 539. Minimum Time Difference
    // https://leetcode.com/problems/minimum-time-difference/description/
    internal class Program
    {
        public int FindMinDifference(IList<string> timePoints)
        {
            int minDifference = int.MaxValue;
            List<int> minutes = new List<int>();
            foreach (string timePoint in timePoints)
            {
                string[] time = timePoint.Split(':');
                int curMinutes = int.Parse(time[0]) * 60 + int.Parse(time[1]);
                if (minutes.Contains(curMinutes))
                    return 0;
                else
                    minutes.Add(curMinutes);
            }

            minutes.Sort();
            for (int i = 0; i < minutes.Count - 1; i++)
                minDifference = Math.Min(minDifference, minutes[i + 1] - minutes[i]);

            return Math.Min(minDifference, 24 * 60 - minutes[minutes.Count - 1] + minutes[0]);
        }

        static void Main(string[] args)
        {
        }
    }
}
