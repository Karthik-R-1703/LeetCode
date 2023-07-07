using System;
using System.Linq;

namespace Problem_151
{
    // 151. Reverse Words in a String
    // https://leetcode.com/problems/reverse-words-in-a-string/
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public string ReverseWords(string s)
        {
            return string.Join(" ", s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Reverse());
        }
    }
}
