using System;
using System.Linq;

namespace Problem_557
{
    // 557. Reverse Words in a String III
    // https://leetcode.com/problems/reverse-words-in-a-string-iii/
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = ReverseWords("Let's take LeetCode contest");
            string s2 = ReverseWords("God Ding");
        }

        public static string ReverseWords(string s)
        {
            return string.Join(" ", s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => new string(x.Reverse().ToArray())));
        }
    }
}
