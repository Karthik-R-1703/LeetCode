using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_68
{
    // 68. Text Justification
    // https://leetcode.com/problems/text-justification/
    internal class Program
    {
        public static IList<string> FullJustify(string[] words, int maxWidth)
        {
            int count = words.Length;
            int curr = 0;
            List<string> result = new List<string>();
            StringBuilder sb = new StringBuilder(maxWidth);
            while (curr < count)
            {
                int width = 0;
                int first = curr;
                while (curr < count && width + words[curr].Length <= maxWidth)
                {
                    width = width + words[curr].Length + 1;
                    curr++;
                }

                int gaps = curr - first - 1;
                int spaces = maxWidth - (width - 1) + gaps;
                int spacesBetween = (gaps > 1) ? spaces / gaps : spaces;
                int rem = spaces - spacesBetween * gaps;
                for (int i = first; i < curr; i++)
                {
                    sb.Append(words[i]);
                    if (i != curr - 1)
                    {
                        int s = 1;
                        if (curr < words.Length)
                        {
                            s = spacesBetween;
                            if (rem-- > 0)
                                s += 1;
                        }

                        sb.Append(' ', s);
                    }
                }

                sb.Append(' ', maxWidth - sb.Length);
                result.Add(sb.ToString());
                sb.Clear();
            }

            return result;
        }

        static void Main(string[] args)
        {
            string[] words1 = { "This", "is", "an", "example", "of", "text", "justification." };
            IList<string> result1 = FullJustify(words1, 16);
            Console.WriteLine("Example 1:");
            foreach (string line in result1)
            {
                Console.WriteLine(line);
            }

            string[] words2 = { "What", "must", "be", "acknowledgment", "shall", "be" };
            IList<string> result2 = FullJustify(words2, 16);
            Console.WriteLine("\nExample 2:");
            foreach (string line in result2)
            {
                Console.WriteLine(line);
            }

            string[] words3 = { "Science", "is", "what", "we", "understand", "well", "enough", "to", "explain", "to", "a", "computer.", "Art", "is", "everything", "else", "we", "do" };
            IList<string> result3 = FullJustify(words3, 20);
            Console.WriteLine("\nExample 3:");
            foreach (string line in result3)
            {
                Console.WriteLine(line);
            }
        }
    }
}
