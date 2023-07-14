using System.Collections.Generic;

namespace Problem_383
{
    // 383. Ransom Note
    // https://leetcode.com/problems/ransom-note/
    internal class Program
    {
        public static bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<char, int> magazines = new Dictionary<char, int>();
            foreach (char c in magazine)
            {
                if (magazines.ContainsKey(c))
                {
                    magazines[c]++;
                }
                else
                {
                    magazines.Add(c, 1);
                }
            }

            foreach (char c in ransomNote)
            {
                if (magazines.ContainsKey(c))
                {
                    if (magazines[c] > 0)
                    {
                        magazines[c]--;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            CanConstruct("a", "b");
            CanConstruct("aa", "ab");
            CanConstruct("aa", "aab");
        }
    }
}
