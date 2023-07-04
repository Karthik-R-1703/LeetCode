namespace Problem_28
{
    // 28. Find the Index of the First Occurrence in a String
    // https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/
    internal class Program
    {
        static void Main(string[] args)
        {
            StrStr("sadbutsad", "sad");
            StrStr("leetcode", "leeto");
            StrStr("aaa", "aaaa");
            StrStr("mississippi", "issip");
        }

        public static int StrStr(string haystack, string needle)
        {
            int startIndex = -1;
            int j = 0;

            for (int i = 0; i < haystack.Length; i++)
            {
                int t = i;
                while (haystack[i] == needle[j])
                {
                    if (startIndex == -1)
                        startIndex = i;

                    i++;
                    j++;

                    if (i == haystack.Length || j == needle.Length)
                        break;
                }

                if (i == haystack.Length || j == needle.Length)
                    break;

                startIndex = -1;
                j = 0;
                i = t;
            }

            if (j != needle.Length)
                startIndex = -1;

            return startIndex;
        }
    }
}
