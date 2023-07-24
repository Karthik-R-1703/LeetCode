using System.Collections.Generic;

namespace Problem_13
{
    // 13. Roman to Integer
    // https://leetcode.com/problems/roman-to-integer/
    internal class Program
    {
        static void Main(string[] args)
        {
            RomanToInt("III");
            RomanToInt("LVIII");
            RomanToInt("MCMXCIV");
        }

        public static int RomanToInt(string s)
        {
            Dictionary<char, int> romanDict = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            int total = 0;
            int i = 0;

            while (i < s.Length)
            {
                if (i + 1 < s.Length && romanDict[s[i]] < romanDict[s[i + 1]])
                {
                    total += romanDict[s[i + 1]] - romanDict[s[i]];
                    i += 2;
                }
                else
                {
                    total += romanDict[s[i]];
                    i += 1;
                }
            }

            return total;
        }
    }
}
