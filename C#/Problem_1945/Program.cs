namespace Problem_1945
{
    // 1945. Sum of Digits of String After Convert
    // https://leetcode.com/problems/sum-of-digits-of-string-after-convert/description/
    internal class Program
    {
        public static int GetLucky(string s, int k)
        {
            string num = string.Empty;
            foreach (char c in s)
            {
                int digit = c - '0' - 48;
                num = num + digit.ToString();
            }

            for (int i = 1; i <= k; i++)
            {
                int tempSum = 0;
                foreach (char c in num)
                {
                    tempSum = tempSum + c - '0';
                }

                num = tempSum.ToString();
            }

            return int.Parse(num);
        }

        static void Main(string[] args)
        {
            GetLucky("iiii", 1);
            GetLucky("leetcode", 2);
        }
    }
}
