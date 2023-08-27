namespace Problem_258
{
    // 258. Add Digits
    // https://leetcode.com/problems/add-digits/
    internal class Program
    {
        public static long AddDigits(long num)
        {
            if (num <= 9)
                return num;

            long digits = 0;
            while (num > 0)
            {
                digits += num % 10;
                num /= 10;
            }

            if (digits > 9)
                digits = AddDigits(digits);

            return digits;
        }

        static void Main(string[] args)
        {
            AddDigits(38);
            AddDigits(0);
        }
    }
}
