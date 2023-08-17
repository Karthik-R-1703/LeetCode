namespace Problem_121
{
    // 121. Best Time to Buy and Sell Stock
    // https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
    internal class Program
    {
        static void Main(string[] args)
        {
            MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });
            MaxProfit(new int[] { 7, 6, 4, 3, 1 });
        }

        public static int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                int buy = prices[i];
                int max = 0;
                for (int j = i + 1; j < prices.Length; j++)
                {
                    int sell = prices[j];
                    int profit = sell - buy;
                    if (profit > max)
                        max = profit;
                }

                if (max > maxProfit)
                    maxProfit = max;
            }

            return maxProfit;
        }
    }
}
