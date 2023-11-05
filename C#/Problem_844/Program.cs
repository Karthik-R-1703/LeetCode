namespace Problem_844
{
    // 844. Backspace String Compare
    // https://leetcode.com/problems/backspace-string-compare/description/
    internal class Program
    {
        public static bool BackspaceCompare(string s, string t)
        {
            char[] sChars = s.ToCharArray();
            char[] tChars = t.ToCharArray();

            int s_l = StringLength(sChars);
            int t_l = StringLength(tChars);

            if (s_l != t_l)
                return false;

            for (int i = 0; i < s_l; i++)
            {
                if (sChars[i] != tChars[i])
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            BackspaceCompare("ab#c", "ad#c");
            BackspaceCompare("ab##", "c#d#");
            BackspaceCompare("a#c", "b");
        }

        public static int StringLength(char[] chars)
        {
            int i = 0;
            foreach (char c in chars)
            {
                if (c != '#')
                {
                    chars[i++] = c;
                }
                else if (i > 0)
                {
                    i--;
                }
            }

            return i;
        }
    }
}
