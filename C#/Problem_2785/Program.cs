using System.Collections.Generic;
using System.Text;

namespace Problem_2785
{
    // 2785. Sort Vowels in a String
    // https://leetcode.com/problems/sort-vowels-in-a-string/description/
    internal class Program
    {
        static void Main(string[] args)
        {
            SortVowels("lEetcOde");
            SortVowels("lYmpH");
        }

        public static string SortVowels(string s)
        {
            List<char> VowelsList = new List<char>()
            {
                'A',
                'E',
                'I',
                'O',
                'U',
                'a',
                'e',
                'i',
                'o',
                'u'
            };

            List<char> Vowels = new List<char>();
            StringBuilder result = new StringBuilder();
            foreach (char c in s)
            {
                if (VowelsList.Contains(c))
                {
                    Vowels.Add(c);
                }
            }

            Vowels.Sort();
            int i = 0;
            foreach (char c in s)
            {
                if (VowelsList.Contains(c))
                {
                    result.Append(Vowels[i++]);
                }
                else
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
    }
}
