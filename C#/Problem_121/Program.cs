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
            MaxProfit(new int[] { 1, 2 });
        }

        public static int MaxProfit(int[] prices)
        {
            int buy = int.MaxValue;
            int maxProfit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                int sell = prices[i];
                if (sell < buy)
                    buy = sell;

                int profit = sell - buy;
                if (profit > maxProfit)
                    maxProfit = profit;
            }

            return maxProfit;
        }
    }
}
