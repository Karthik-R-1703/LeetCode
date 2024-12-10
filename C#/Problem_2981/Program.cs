using System;
using System.Collections.Generic;

namespace Problem_2981
{
    // 2981. Find Longest Special Substring That Occurs Thrice I
    // https://leetcode.com/problems/find-longest-special-substring-that-occurs-thrice-i/description/
    internal class Program
    {
        static void Main(string[] args)
        {
            MaximumLength("aaaa");
            MaximumLength("abcdef");
            MaximumLength("abcaba");
            MaximumLength("acc");
            MaximumLength("aaa");
            MaximumLength("abcccccddddabcccccddddabcccccdddd");
            MaximumLength("jinhhhtttttttefffffjjjjjjjjjfffffjjjjjjjjjzvvvvvvg");
            MaximumLength("aaaaaaaaaaaaccccccccccccccccccccccccccaaaaaaaaaaaa");
            MaximumLength("aaaaaaaaaaaaaaaaaaaabbbbbbbbbbaaaaaaaaaaaaaaaaaaaa");
            MaximumLength("zzzzzzzzzzzzzzzzzfffffdddddddddiiiiiiiiiiiiiiiiiii");
            MaximumLength("zzzzzzzzzzzsssssssssssssssssqppppppppppppppnqmosat");
        }

        public static int MaximumLength(string s)
        {
            HashSet<string> Patterns = new HashSet<string>();
            char prevChar = '\0';
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == prevChar)
                    count++;
                else
                {
                    prevChar = s[i];
                    count = 1;
                }

                Patterns.Add(s[i].ToString());
                string newChar = new string(prevChar, count);
                Patterns.Add(newChar);
            }

            Dictionary<string, int> Counts = new Dictionary<string, int>();
            foreach (string pattern in Patterns)
            {
                count = 0;
                for (int i = 0; i <= s.Length - pattern.Length; i++)
                    if (s.Substring(i, pattern.Length) == pattern)
                        count++;

                Counts[pattern] = count;
            }

            int maxLength = -1;
            foreach (KeyValuePair<string, int> pair in Counts)
                if (pair.Value >= 3)
                    maxLength = Math.Max(maxLength, pair.Key.Length);

            return maxLength;
        }
    }
}
