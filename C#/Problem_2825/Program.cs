namespace Problem_2825
{
    // 2825. Make String a Subsequence Using Cyclic Increments
    // https://leetcode.com/problems/make-string-a-subsequence-using-cyclic-increments/description/
    internal class Program
    {
        public static bool CanMakeSubsequence(string str1, string str2)
        {
            int i = 0, j = 0;
            int s1 = str1.Length, s2 = str2.Length;
            while (i < s1 && j < s2)
            {
                char nextChar = (str1[i] == 'z') ? 'a' : (char)(str1[i] + 1);
                if (str1[i] == str2[j] || nextChar == str2[j])
                    j++;

                i++;
            }

            return j == s2;
        }

        static void Main(string[] args)
        {
            CanMakeSubsequence("abc", "ad");
            CanMakeSubsequence("zc", "ad");
            CanMakeSubsequence("ab", "d");
        }
    }
}
