using System.Linq;

namespace Problem_2554
{
    // 2554. Maximum Number of Integers to Choose From a Range I
    // https://leetcode.com/problems/maximum-number-of-integers-to-choose-from-a-range-i/description/
    internal class Program
    {
        static void Main(string[] args)
        {
            MaxCount(new int[] { 1, 6, 5 }, 5, 6);
            MaxCount(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 8, 1);
            MaxCount(new int[] { 11 }, 7, 50);
        }

        public static int MaxCount(int[] banned, int n, int maxSum)
        {
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (banned.Contains(i))
                    continue;

                maxSum -= i;
                if (maxSum < 0)
                    break;

                count++;
            }

            return count;
        }
    }
}
