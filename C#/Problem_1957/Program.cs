using System.Text;

namespace Problem_1957
{
    // 1957. Delete Characters to Make Fancy String
    // https://leetcode.com/problems/delete-characters-to-make-fancy-string/description/
    internal class Program
    {
        static void Main(string[] args)
        {
            MakeFancyString("leeetcode");
        }

        public static string MakeFancyString(string s)
        {
            StringBuilder fancyString = new StringBuilder();
            char prevChar = ' ';
            int count = 1;
            foreach (char c in s)
            {
                if (c == prevChar)
                {
                    if (++count < 3)
                    {
                        fancyString.Append(c);
                    }
                }
                else
                {
                    prevChar = c;
                    count = 1;
                    fancyString.Append(c);
                }
            }

            return fancyString.ToString();
        }
    }
}
