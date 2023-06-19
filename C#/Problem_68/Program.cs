using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_68
{
    // 68. Text Justification
    // https://leetcode.com/problems/text-justification/
    internal class Program
    {
        public static IList<string> FullJustify(string[] words, int maxWidth)
        {
            IList<string> lines = new List<string>();
            int lineLength = 0;
            string line = string.Empty;

            foreach (string word in words)
            {
                if (lineLength + word.Length > maxWidth)
                {
                    int spaces = maxWidth - lineLength;
                    int spacePerWord = 1;
                    int extraSpaces = 0;
                    int wordCount = 1;
                    if (line.Length > 0)
                    {
                        wordCount = line.Split(' ').Length;
                    }

                    if (wordCount > 1)
                    {
                        spacePerWord = spaces / (wordCount - 1);
                        extraSpaces = spaces % (wordCount - 1);
                    }

                    string newLine = string.Empty;
                    string[] wordsInLine = line.Split(' ');

                    for (int i = 0; i < wordsInLine.Length; i++)
                    {
                        newLine += wordsInLine[i];
                        if (i < wordsInLine.Length - 1)
                        {
                            int spacesToAdd = spacePerWord + (extraSpaces > 0 ? 1 : 0);
                            newLine += string.Empty.PadLeft(spacesToAdd, ' ');
                            extraSpaces--;
                        }
                    }

                    lines.Add(newLine);
                    line = string.Empty;
                    lineLength = 0;
                }

                if (line.Length > 0)
                {
                    line += ' ';
                    lineLength++;
                }

                line += word;
                lineLength += word.Length;

                if (lineLength != line.Length)
                {

                }
            }

            if (line.Length > 0)
            {
                int spacesToAdd = maxWidth - lineLength;
                line += string.Empty.PadLeft(spacesToAdd, ' ');
                lines.Add(line);
            }

            return lines;
        }

        static void Main(string[] args)
        {
            string[] words1 = { "This", "is", "an", "example", "of", "text", "justification." };
            FullJustify(words1, 16);

            string[] words2 = { "What", "must", "be", "acknowledgment", "shall", "be" };
            FullJustify(words2, 16);

            string[] words3 = { "Science", "is", "what", "we", "understand", "well", "enough", "to", "explain", "to", "a", "computer.", "Art", "is", "everything", "else", "we", "do" };
            FullJustify(words3, 20);
        }
    }
}
