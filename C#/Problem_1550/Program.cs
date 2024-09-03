namespace Problem_1550
{
    // 1550. Three Consecutive Odds
    // https://leetcode.com/problems/three-consecutive-odds/description/
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static bool ThreeConsecutiveOdds(int[] arr)
        {
            int count = 0;
            foreach (int i in arr)
            {
                if (i % 2 != 0)
                    count++;
                else
                    count = 0;

                if (count == 3)
                    return true;
            }

            return false;
        }
    }
}
