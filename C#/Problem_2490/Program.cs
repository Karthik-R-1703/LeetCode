using System.Linq;

namespace Problem_2490
{
    // 2490. Circular Sentence
    // https://leetcode.com/problems/circular-sentence/description/
    internal class Program
    {
        public static bool IsCircularSentence(string sentence)
        {
            string[] words = sentence.Split(new char[] { ' ' });
            int n = words.Length;
            char lastChar = words[n - 1].Last();
            for (int i = 0; i < n; i++)
            {
                if (words[i].First() != lastChar)
                    return false;

                lastChar = words[i].Last();
            }

            return true;
        }

        static void Main(string[] args)
        {
        }
    }
}
