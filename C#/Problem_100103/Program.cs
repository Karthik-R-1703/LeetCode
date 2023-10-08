namespace Problem_100103
{
    // 100103. Divisible and Non-divisible Sums Difference
    internal class Program
    {
        public static int DifferenceOfSums(int n, int m)
        {
            int num1 = 0;
            int num2 = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % m == 0)
                    num2 += i;
                else
                    num1 += i;
            }

            return num1 - num2;
        }

        static void Main(string[] args)
        {
            DifferenceOfSums(10, 3);
            DifferenceOfSums(5, 6);
            DifferenceOfSums(5, 1);
        }
    }
}
