namespace Problem_14
{
    // 14. Longest Common Prefix
    // https://leetcode.com/problems/longest-common-prefix/
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strs1 = { "flower", "flow", "flight" };
            LongestCommonPrefix(strs1);

            string[] strs2 = { "dog", "racecar", "car" };
            LongestCommonPrefix(strs2);
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            string longestCommonPrefix = string.Empty;

            if (strs.Length == 0)
            {
                return longestCommonPrefix;
            }

            longestCommonPrefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                if (string.IsNullOrEmpty(longestCommonPrefix))
                    break;

                string str = strs[i];
                int j = 0;
                while (j < longestCommonPrefix.Length && j < str.Length && longestCommonPrefix[j] == str[j])
                    j++;

                longestCommonPrefix = longestCommonPrefix.Substring(0, j);
            }

            return longestCommonPrefix;
        }
    }
}
