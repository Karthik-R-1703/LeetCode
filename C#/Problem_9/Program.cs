namespace Problem_9
{
    // 9. Palindrome Number
    // https://leetcode.com/problems/palindrome-number/
    internal class Program
    {
        public static bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }

            int reversedNum = 0;
            int num = x;
            while (x > 0)
            {
                reversedNum = reversedNum * 10 + x % 10;
                x /= 10;
            }

            return num == reversedNum;
        }

        static void Main(string[] args)
        {
            IsPalindrome(121);
        }
    }
}
