using System;

namespace Problem_1455
{
    // 1455. Check If a Word Occurs As a Prefix of Any Word in a Sentence
    // https://leetcode.com/problems/check-if-a-word-occurs-as-a-prefix-of-any-word-in-a-sentence/description/
    internal class Program
    {
        public int IsPrefixOfWord(string sentence, string searchWord)
        {
            string[] words = sentence.Split(new char[] { ' ' });
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].StartsWith(searchWord, StringComparison.OrdinalIgnoreCase))
                    return i + 1;
            }

            return -1;
        }

        static void Main(string[] args)
        {
        }
    }
}
