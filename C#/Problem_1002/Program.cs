using System;
using System.Collections.Generic;

namespace Problem_1002
{
    // 1002. Find Common Characters
    // https://leetcode.com/problems/find-common-characters/description/
    internal class Program
    {
        public static IList<string> CommonChars(string[] words)
        {
            List<string> result = new List<string>();
            bool isFirst = true;
            Dictionary<char, int> CommonMap = new Dictionary<char, int>();
            foreach (string word in words)
            {
                Dictionary<char, int> map = StringToDictionary(word);
                if (isFirst)
                {
                    isFirst = false;
                    CommonMap = map;
                }
                else
                {
                    Dictionary<char, int> TempMap = new Dictionary<char, int>();
                    foreach (KeyValuePair<char, int> pair in map)
                    {
                        if (CommonMap.ContainsKey(pair.Key))
                        {
                            TempMap.Add(pair.Key, Math.Min(pair.Value, CommonMap[pair.Key]));
                        }
                    }

                    CommonMap = TempMap;
                }
            }

            foreach (KeyValuePair<char, int> pair in CommonMap)
            {
                for (int i = 0; i < pair.Value; i++)
                {
                    result.Add(pair.Key.ToString());
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            CommonChars(new string[] { "bella", "label", "roller" });
        }

        private static Dictionary<char, int> StringToDictionary(string str)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach (char c in str)
            {
                if (map.ContainsKey(c))
                {
                    map[c]++;
                }
                else
                {
                    map.Add(c, 1);
                }
            }

            return map;
        }
    }
}
