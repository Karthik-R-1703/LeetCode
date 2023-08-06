using System.Collections.Generic;

namespace Problem_3
{
    // 3. Longest Substring Without Repeating Characters
    // https://leetcode.com/problems/longest-substring-without-repeating-characters/
    internal class Program
    {
        public static int LengthOfLongestSubstring(string s)
        {
            int str_length = s.Length;

            if (str_length == 0)
                return 0;

            if (str_length == 1)
                return 1;

            int maxLength = 0;
            int left = 0;
            int right = 1;
            while (left < str_length)
            {
                int tmp_length = 1;
                HashSet<int> tmp = new HashSet<int>();
                tmp.Add(s[left]);
                while (right < str_length && !tmp.Contains(s[right]))
                {
                    tmp.Add(s[right]);
                    right++;
                    tmp_length++;
                }

                if (tmp_length > maxLength)
                    maxLength = tmp_length;

                left++;
                right = left + 1;
            }

            return maxLength;
        }

        static void Main(string[] args)
        {
            LengthOfLongestSubstring("au");
            LengthOfLongestSubstring("abcabcbb");
            LengthOfLongestSubstring("bbbbb");
            LengthOfLongestSubstring("pwwkew");
        }
    }
}
