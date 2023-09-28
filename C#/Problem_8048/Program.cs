namespace Problem_8048
{
    // 8048. Maximum Odd Binary Number
    // 2864. Maximum Odd Binary Number
    // https://leetcode.com/problems/maximum-odd-binary-number/description/
    internal class Program
    {
        static void Main(string[] args)
        {
            MaximumOddBinaryNumber("010");
            MaximumOddBinaryNumber("0101");
        }

        public static string MaximumOddBinaryNumber(string s)
        {
            int count = 0;
            int total = s.Length;

            foreach (char c in s)
            {
                if (c == '1')
                {
                    count++;
                }
            }

            string result = string.Empty;

            result = result.PadLeft(count - 1, '1');
            result = result.PadRight(total - 1, '0');
            result = result.PadRight(total, '1');
            return result;
        }
    }
}
