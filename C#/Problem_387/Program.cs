using System.Collections.Generic;
using System.Linq;

namespace Problem_387
{
    // 387. First Unique Character in a String
    // https://leetcode.com/problems/first-unique-character-in-a-string/
    internal class Program
    {
        public static int FirstUniqChar(string s)
        {
            Dictionary<char, int> charOccurrences = s.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
            for (int i = 0; i < charOccurrences.Count; i++)
            {
                if (charOccurrences.ElementAt(i).Value == 1)
                    return s.IndexOf(charOccurrences.ElementAt(i).Key);
            }

            return -1;
        }

        static void Main(string[] args)
        {
            FirstUniqChar("leetcode");
            FirstUniqChar("loveleetcode");
            FirstUniqChar("aabb");
            FirstUniqChar("dddccdbba");
        }
    }
}
