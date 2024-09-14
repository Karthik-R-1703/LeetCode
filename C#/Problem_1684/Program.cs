using System.Collections.Generic;

namespace Problem_1684
{
    // 1684. Count the Number of Consistent Strings
    // https://leetcode.com/problems/count-the-number-of-consistent-strings/description/
    internal class Program
    {
        public static int CountConsistentStrings(string allowed, string[] words)
        {
            int count = 0;
            HashSet<char> allowedChars = new HashSet<char>(allowed);
            foreach (string word in words)
            {
                bool isConsistent = true;
                foreach (char c in word)
                {
                    if (!allowedChars.Contains(c))
                    {
                        isConsistent = false;
                        break;
                    }
                }

                if (isConsistent)
                    count++;
            }

            return count;
        }

        static void Main(string[] args)
        {
        }
    }
}
