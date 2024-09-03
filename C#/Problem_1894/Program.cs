namespace Problem_1894
{
    // 1894. Find the Student that Will Replace the Chalk
    // https://leetcode.com/problems/find-the-student-that-will-replace-the-chalk/description/
    internal class Program
    {
        public static int ChalkReplacer(int[] chalk, int k)
        {
            int sum = 0;
            for (int i = 0; i < chalk.Length; i++)
            {
                sum += chalk[i];
                if (sum > k)
                {
                    break;
                }
            }

            k = k % sum;
            for (int i = 0; i < chalk.Length; i++)
            {
                if (k < chalk[i])
                {
                    return i;
                }

                k -= chalk[i];
            }

            return 0;
        }

        static void Main(string[] args)
        {
        }
    }
}
