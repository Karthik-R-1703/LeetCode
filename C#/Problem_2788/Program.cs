using System;
using System.Collections.Generic;

namespace Problem_2788
{
    // 2788. Split Strings by Separator
    // https://leetcode.com/problems/split-strings-by-separator/description/
    internal class Program
    {
        static void Main(string[] args)
        {
            SplitWordsBySeparator(new List<string> { "one.two.three", "four.five", "six" }, '.');
            SplitWordsBySeparator(new List<string> { "$easy$", "$problem$" }, '$');
            SplitWordsBySeparator(new List<string> { "|||" }, '|');
        }

        public static IList<string> SplitWordsBySeparator(IList<string> words, char separator)
        {
            List<string> result = new List<string>();
            foreach (string word in words)
            {
                result.AddRange(word.Split(new char[] { separator }, StringSplitOptions.RemoveEmptyEntries));
            }

            return result;
        }
    }
}
