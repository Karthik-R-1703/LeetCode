using System.Text.RegularExpressions;

namespace Problem_125
{
    // 125. Valid Palindrome
    // https://leetcode.com/problems/valid-palindrome/
    internal class Program
    {
        public static bool IsPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            Regex regex = new Regex("^[a-zA-Z0-9]+$");

            while (left < right)
            {
                while (left < s.Length && !regex.IsMatch(s[left].ToString().ToUpperInvariant()))
                {
                    left++;
                }

                while (right >= 0 && !regex.IsMatch(s[right].ToString().ToUpperInvariant()))
                {
                    right--;
                }

                if (left < s.Length && right >= 0)
                {
                    if (s[left].ToString().ToUpperInvariant() != s[right].ToString().ToUpperInvariant())
                    {
                        return false;
                    }
                    else
                    {
                        left++;
                        right--;
                    }
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            IsPalindrome("A man, a plan, a canal: Panama");
            IsPalindrome("race a car");
            IsPalindrome(" ");
        }
    }
}
