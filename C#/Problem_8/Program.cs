namespace Problem_8
{
    // 8. String to Integer (atoi)
    // https://leetcode.com/problems/string-to-integer-atoi/
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = MyAtoi("42");
            int num2 = MyAtoi("   -42");
            int num3 = MyAtoi("4193 with words");
            int num4 = MyAtoi("words and 987");
            int num5 = MyAtoi("-91283472332");
            int num6 = MyAtoi("9223372036854775808");
            int num7 = MyAtoi(" ++1");
        }

        public static int MyAtoi(string s)
        {
            string s_num = string.Empty;
            bool isPositive = true;

            s = s.Trim();

            if (s.StartsWith("+"))
            {
                s = s.Substring(1);
            }
            else if (s.StartsWith("-"))
            {
                isPositive = false;
                s = s.Substring(1);
            }

            foreach (char c in s)
            {
                if (char.IsDigit(c))
                {
                    s_num += c;
                }
                else
                {
                    break;
                }
            }

            if (int.TryParse(s_num, out int num))
            {
                if (!isPositive)
                {
                    num *= -1;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(s_num))
                    return 0;

                if (isPositive)
                {
                    return int.MaxValue;
                }
                else
                {
                    return int.MinValue;
                }
            }

            return num;
        }
    }
}
