namespace Problem_680
{
    // 680. Valid Palindrome II
    // https://leetcode.com/problems/valid-palindrome-ii/
    internal class Program
    {
        public static bool IsPalindrome(string s, int left, int right)
        {
            while (left < right)
            {
                if (s[left] != s[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }

        static void Main(string[] args)
        {
            ValidPalindrome("abca");
            ValidPalindrome("abca");
            ValidPalindrome("abc");
            ValidPalindrome("deeee");
        }

        public static bool ValidPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (s[left] != s[right])
                {
                    return IsPalindrome(s, left + 1, right) || IsPalindrome(s, left, right - 1);
                }

                left++;
                right--;
            }

            return true;
        }
    }
}
