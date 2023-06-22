namespace Problem_392
{
    // 392. Is Subsequence
    // https://leetcode.com/problems/is-subsequence/
    internal class Program
    {
        public static bool IsSubsequence(string s, string t)
        {
            if (string.IsNullOrEmpty(s))
            {
                return true;
            }

            int str_len = 0;

            for (int i = 0; i < t.Length; i++)
            {
                if (str_len < s.Length && s[str_len] == t[i])
                {
                    str_len++;
                }
            }

            if (str_len == s.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            string s = "abc", t = "ahbgdc";
            IsSubsequence(s, t);
        }
    }
}
