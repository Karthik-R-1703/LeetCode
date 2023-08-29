using System.Linq;

namespace Problem_2483
{
    // 2483. Minimum Penalty for a Shop
    // https://leetcode.com/problems/minimum-penalty-for-a-shop/
    internal class Program
    {
        public static int BestClosingTime(string customers)
        {
            int totalYCount = customers.Count(x => x == 'Y');
            int totalNCount = 0;
            int minPenalty = totalYCount;
            int minPenaltyIndex = 0;

            for (int i = 0; i < customers.Length; i++)
            {
                if (customers[i] == 'Y')
                    totalYCount--;
                else
                    totalNCount++;

                int curPenalty = totalYCount - totalNCount;
                if (curPenalty < minPenalty)
                {
                    minPenalty = curPenalty;
                    minPenaltyIndex = i + 1;
                }
            }

            return minPenaltyIndex;
        }

        static void Main(string[] args)
        {
            BestClosingTime("YYNY");
            BestClosingTime("NNNNN");
            BestClosingTime("YYYY");
        }
    }
}
