namespace Problem_258
{
    // 258. Add Digits
    // https://leetcode.com/problems/add-digits/
    internal class Program
    {
        public static int AddDigits(int num)
        {
            if (num <= 9)
                return num;

            int digits = 0;
            while (num > 0)
            {
                digits += num % 10;
                num /= 10;

                if (num == 0 && digits > 9)
                {
                    num = digits;
                    digits = 0;
                }
            }

            return digits;
        }

        static void Main(string[] args)
        {
            AddDigits(38);
            AddDigits(0);
        }
    }
}
