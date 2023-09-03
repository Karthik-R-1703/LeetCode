using System;
using System.Linq;

namespace Problem_7021
{
    // 7021. Check if Strings Can be Made Equal With Operations I
    // 2839. Check if Strings Can be Made Equal With Operations I
    // https://leetcode.com/problems/check-if-strings-can-be-made-equal-with-operations-i/
    internal class Program
    {
        public static bool CanBeEqual(string s1, string s2)
        {
            char[] c_s1 = s1.ToCharArray();
            char[] c_s2 = s2.ToCharArray();

            Array.Sort(c_s1);
            Array.Sort(c_s2);
            if (!c_s1.SequenceEqual(c_s2))
                return false;

            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == s2[i])
                {
                    continue;
                }
                else
                {
                    int j = s2.Substring(i).IndexOf(s1[i]) + i;
                    if (Math.Abs(j - i) != 2)
                    {
                        return false;
                    }
                    else
                    {
                        char[] charArray = s2.ToCharArray();

                        char temp = charArray[i];
                        charArray[i] = charArray[j];
                        charArray[j] = temp;

                        s2 = new string(charArray);
                    }
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            CanBeEqual("abcd", "cdab");
            CanBeEqual("abcd", "dacb");
            CanBeEqual("bbfp", "fbbp");
        }
    }
}
