using System.Collections.Generic;
using System.Linq;

namespace Problem_1732
{
    // 1732. Find the Highest Altitude
    // https://leetcode.com/problems/find-the-highest-altitude/
    internal class Program
    {
        public int LargestAltitude(int[] gain)
        {
            List<int> altitudes = new List<int> { 0 };
            foreach (int i in gain)
            {
                altitudes.Add(altitudes[altitudes.Count - 1] + i);
            }

            return altitudes.Max();
        }

        static void Main(string[] args)
        {
            int[] gain = { -5, 1, 5, 0, -7 };
        }
    }
}
