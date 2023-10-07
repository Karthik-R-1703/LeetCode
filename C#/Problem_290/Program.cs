using System;
using System.Collections.Generic;

namespace Problem_290
{
    // 290. Word Pattern
    // https://leetcode.com/problems/word-pattern/description/
    internal class Program
    {
        static void Main(string[] args)
        {
            WordPattern("abba", "dog cat cat dog");
            WordPattern("abba", "dog cat cat fish");
            WordPattern("aaaa", "dog cat cat dog");
            WordPattern("abba", "dog dog dog dog");
            WordPattern("aaa", "aa aa aa aa");
        }

        public static bool WordPattern(string pattern, string s)
        {
            string[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (pattern.Length != words.Length)
                return false;

            Dictionary<char, string> patternMap = new Dictionary<char, string>();
            for (int i = 0; i < words.Length; i++)
            {
                if (patternMap.ContainsKey(pattern[i]))
                {
                    if (patternMap[pattern[i]] != words[i])
                        return false;
                }
                else if (patternMap.ContainsValue(words[i]))
                    return false;
                else
                    patternMap.Add(pattern[i], words[i]);
            }

            return true;
        }
    }
}
