namespace Problem_1672
{
    // 1672. Richest Customer Wealth
    // https://leetcode.com/problems/richest-customer-wealth/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] mat1 = new int[][] {
                new int[] { 1, 2, 3 },
                new int[] { 3, 2, 1 }
            };

            MaximumWealth(mat1);

            int[][] mat2 = new int[][] {
                new int[] { 1, 5 },
                new int[] { 7, 3 },
                new int[] { 3, 5 }
            };

            MaximumWealth(mat2);

            int[][] mat3 = new int[][] {
                new int[] { 2, 8, 7 },
                new int[] { 7, 1, 3 },
                new int[] { 1, 9, 5 }
            };

            MaximumWealth(mat3);
        }

        public static int MaximumWealth(int[][] accounts)
        {
            int maxWealth = 0;
            foreach (int[] account in accounts)
            {
                int wealth = 0;
                foreach (int i in account)
                {
                    wealth += i;
                }

                if (wealth > maxWealth)
                    maxWealth = wealth;
            }

            return maxWealth;
        }
    }
}
