namespace Problem_338
{
    // 338. Counting Bits
    // https://leetcode.com/problems/counting-bits/
    internal class Program
    {
        public static int[] CountBits(int n)
        {
            int[] numOfBits = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                numOfBits[i] = numOfBits[i >> 1] + (i & 1);
            }

            return numOfBits;
        }

        static void Main(string[] args)
        {
            CountBits(2);
            CountBits(5);
        }
    }
}
