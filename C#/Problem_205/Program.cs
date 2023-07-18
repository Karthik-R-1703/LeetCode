using System.Collections.Generic;

namespace Problem_205
{
    // 205. Isomorphic Strings
    // https://leetcode.com/problems/isomorphic-strings/
    internal class Program
    {
        public static bool IsIsomorphic(string s, string t)
        {
            Dictionary<char, char> v = new Dictionary<char, char>();
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                char r = t[i];
                if (!v.ContainsKey(c) && !v.ContainsValue(r))
                {
                    char[] c_t = t.ToCharArray();
                    c_t[i] = c;
                    t = new string(c_t);
                    v.Add(c, r);
                }
                else if (!v.ContainsKey(c) && v.ContainsValue(r))
                {
                    return false;
                }
                else
                {
                    if (v[c].Equals(r))
                    {
                        char[] c_t = t.ToCharArray();
                        c_t[i] = c;
                        t = new string(c_t);
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            if (string.Compare(s, t, true) != 0)
                return false;

            return true;
        }

        static void Main(string[] args)
        {
            IsIsomorphic("egg", "add");
            IsIsomorphic("foo", "bar");
            IsIsomorphic("paper", "title");
            IsIsomorphic("badc", "baba");
        }
    }
}
