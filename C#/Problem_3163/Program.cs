using System.Text;

namespace Problem_3163
{
    // 3163. String Compression III
    // https://leetcode.com/problems/string-compression-iii/description/
    internal class Program
    {
        public static string CompressedString(string word)
        {
            StringBuilder comp = new StringBuilder();
            word += '\0';
            char prevChar = word[0];
            int totalCount = 0;
            foreach (char c in word)
            {
                if (c == prevChar)
                {
                    totalCount++;
                }
                else
                {
                    while (totalCount > 0)
                    {
                        if (totalCount > 9)
                        {
                            comp.Append("9");
                            comp.Append(prevChar);
                            totalCount -= 9;
                        }
                        else
                        {
                            comp.Append(totalCount);
                            comp.Append(prevChar);
                            totalCount = 0;
                        }
                    }

                    prevChar = c;
                    totalCount = 1;
                }
            }

            return comp.ToString();
        }

        static void Main(string[] args)
        {
            CompressedString("abcde");
        }
    }
}
