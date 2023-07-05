namespace Problem_344
{
    // 344. Reverse String
    // https://leetcode.com/problems/reverse-string/
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] s1 = { 'h', 'e', 'l', 'l', 'o' };
            ReverseString(s1);

            char[] s2 = { 'H', 'a', 'n', 'n', 'a', 'h' };
            ReverseString(s2);
        }

        public static void ReverseString(char[] s)
        {
            int i = 0;
            int j = s.Length - 1;
            while (i < j)
            {
                char c = s[i];
                s[i] = s[j];
                s[j] = c;

                i++;
                j--;
            }
        }
    }
}
