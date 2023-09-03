namespace Problem_7020
{
    // 7020. Count Symmetric Integers
    // 2843. Count Symmetric Integers
    // https://leetcode.com/problems/count-symmetric-integers/
    internal class Program
    {
        public static int CountSymmetricIntegers(int low, int high)
        {
            int count = 0;
            for (int i = low; i <= high; i++)
            {
                string s = i.ToString();
                int l = s.Length;

                if (l % 2 != 0)
                    continue;

                int sum1 = 0;
                int sum2 = 0;
                for (int j = 0; j < l / 2; j++)
                {
                    sum1 += int.Parse(s[j].ToString());
                    sum2 += int.Parse(s[l - j - 1].ToString());
                }

                if (sum1 == sum2)
                    count++;
            }

            return count;
        }

        static void Main(string[] args)
        {
            CountSymmetricIntegers(1, 100);
            CountSymmetricIntegers(1200, 1230);
        }
    }
}
