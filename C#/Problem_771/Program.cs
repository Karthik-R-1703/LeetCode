using System.Collections.Generic;

namespace Problem_771
{
    // 771. Jewels and Stones
    // https://leetcode.com/problems/jewels-and-stones/
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public int NumJewelsInStones(string jewels, string stones)
        {
            int count = 0;
            HashSet<char> set = new HashSet<char>(jewels);
            foreach (char c in stones)
            {
                if (set.Contains(c))
                    count++;
            }

            return count;
        }
    }
}
