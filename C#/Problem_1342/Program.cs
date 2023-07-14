namespace Problem_1342
{
    // 1342. Number of Steps to Reduce a Number to Zero
    // https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/
    internal class Program
    {
        static void Main(string[] args)
        {
            NumberOfSteps(14);
            NumberOfSteps(8);
            NumberOfSteps(123);
        }

        public static int NumberOfSteps(int num)
        {
            int steps = 0;
            while (num > 0)
            {
                steps += num % 2;
                num /= 2;
                if (num != 0)
                    steps++;
            }

            return steps;
        }
    }
}
