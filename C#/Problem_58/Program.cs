namespace Problem_58
{
    // 58. Length of Last Word
    // https://leetcode.com/problems/length-of-last-word/
    internal class Program
    {
        public static int LengthOfLastWord(string s)
        {
            int length = 0;
            s = s.Trim();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ')
                    break;

                length++;
            }

            return length;
        }

        static void Main(string[] args)
        {
            string s1 = "Hello World";
            LengthOfLastWord(s1);

            string s2 = "   fly me   to   the moon  ";
            LengthOfLastWord(s2);

            string s3 = "luffy is still joyboy";
            LengthOfLastWord(s3);
        }
    }
}
