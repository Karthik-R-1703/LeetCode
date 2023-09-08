using System.Collections.Generic;

namespace Problem_7021
{
    // 7021. Check if Strings Can be Made Equal With Operations I
    // 2839. Check if Strings Can be Made Equal With Operations I
    // https://leetcode.com/problems/check-if-strings-can-be-made-equal-with-operations-i/
    internal class Program
    {
        public static bool CanBeEqual(string s1, string s2)
        {
            List<string> Strings = new List<string>
            {
                s1,
                CharString(s1, 0, 2),
                CharString(s1, 1, 3),
                CharString(CharString(s1, 0, 2), 1, 3)
            };

            return Strings.Contains(s2);
        }

        public static string CharString(string s, int i1, int i2)
        {
            char[] charArray = s.ToCharArray();
            (charArray[i1], charArray[i2]) = (charArray[i2], charArray[i1]);
            return new string(charArray);
        }

        static void Main(string[] args)
        {
            CanBeEqual("abcd", "cdab");
            CanBeEqual("abcd", "dacb");
            CanBeEqual("bbfp", "fbbp");
        }
    }
}
