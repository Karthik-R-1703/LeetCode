using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_49
{
    // 49. Group Anagrams
    // https://leetcode.com/problems/group-anagrams/
    internal class Program
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, IList<string>> groupAnagrams = new Dictionary<string, IList<string>>();

            for (int i = 0; i < strs.Length; i++)
            {
                char[] arr = strs[i].ToCharArray();
                Array.Sort(arr);
                string sorted = new string(arr);
                if (groupAnagrams.ContainsKey(sorted))
                {
                    groupAnagrams[sorted].Add(strs[i]);
                }
                else
                {
                    groupAnagrams.Add(sorted, new List<string>() { strs[i] });
                }
            }

            return groupAnagrams.Values.ToList();
        }

        static void Main(string[] args)
        {
            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat", "eats", "seat" };
            IList<IList<string>> groupAnagrams = GroupAnagrams(strs);
        }
    }
}
