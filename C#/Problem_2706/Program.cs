using System;

namespace Problem_2706
{
    // 2706. Buy Two Chocolates
    // https://leetcode.com/problems/buy-two-chocolates/description/
    internal class Program
    {
        public static int BuyChoco(int[] prices, int money)
        {
            Array.Sort(prices);
            int minPrice = int.MaxValue;
            for (int i = 0; i < prices.Length && prices[i] < money; i++)
            {
                for (int j = i + 1; j < prices.Length && prices[j] < money; j++)
                {
                    int price = prices[j] + prices[i];
                    if (price < minPrice && price <= money)
                    {
                        minPrice = price;
                    }
                }
            }

            if (minPrice != int.MaxValue)
            {
                money -= minPrice;
            }

            return money;
        }

        static void Main(string[] args)
        {
            BuyChoco(new int[] { 1, 2, 2 }, 3);
            BuyChoco(new int[] { 3, 2, 3 }, 3);
            BuyChoco(new int[] { 98, 54, 6, 34, 66, 63, 52, 39 }, 62);
            BuyChoco(new int[] { 88, 43, 61 }, 72);
        }
    }
}
