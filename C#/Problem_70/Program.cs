namespace Problem_70
{
    // 70. Climbing Stairs
    // https://leetcode.com/problems/climbing-stairs/
    internal class Program
    {
        public static int ClimbStairs(int n)
        {
            if (n == 0)
                return 0;

            if (n == 1)
                return 1;

            int prev = 1;
            int count = 1;

            for (int i = 2; i <= n; i++)
            {
                int t = count;
                count += prev;
                prev = t;
            }

            return count;
        }

        static void Main(string[] args)
        {
            ClimbStairs(2);
            ClimbStairs(3);
            ClimbStairs(4);
            ClimbStairs(5);
            ClimbStairs(6);
        }
    }
}
