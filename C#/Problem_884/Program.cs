using System.Collections.Generic;
using System.Linq;

namespace Problem_884
{
    // 884. Uncommon Words from Two Sentences
    // https://leetcode.com/problems/uncommon-words-from-two-sentences/description/
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static string[] UncommonFromSentences(string s1, string s2)
        {
            List<string> words = s1.Split(' ').ToList();
            words.AddRange(s2.Split(' '));
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (wordsCount.ContainsKey(word))
                    wordsCount[word]++;
                else
                    wordsCount.Add(word, 1);
            }

            return wordsCount.Where(x => x.Value == 1).Select(x => x.Key).ToArray();
        }
    }
}
