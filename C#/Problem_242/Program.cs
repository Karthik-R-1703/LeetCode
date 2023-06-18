namespace Problem_242
{
    // 242. Valid Anagram
    // https://leetcode.com/problems/valid-anagram/
    internal class Program
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            int[] count = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                count[s[i] - 'a']++;
                count[t[i] - 'a']--;
            }

            for (int i = 0; i < 26; i++)
            {
                if (count[i] != 0)
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
        }
    }
}
