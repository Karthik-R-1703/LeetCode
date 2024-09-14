using System.Linq;

namespace Problem_2028
{
    // 2028. Find Missing Observations
    // https://leetcode.com/problems/find-missing-observations/description/
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static int[] MissingRolls(int[] rolls, int mean, int n)
        {
            int m = rolls.Length;
            int remainingSum = mean * (m + n) - rolls.Sum();
            if (remainingSum > 6 * n || remainingSum < n)
                return new int[] { };

            int distributeMean = remainingSum / n;
            int mod = remainingSum % n;
            int[] rolls_n = new int[n];
            for (int i = 0; i < n; i++)
                rolls_n[i] = distributeMean;

            for (int i = 0; i < mod; i++)
                rolls_n[i]++;

            return rolls_n;
        }
    }
}
