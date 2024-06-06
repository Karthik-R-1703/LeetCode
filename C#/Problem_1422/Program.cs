using System.Linq;

namespace Problem_1422
{
    // 1422. Maximum Score After Splitting a String
    // https://leetcode.com/problems/maximum-score-after-splitting-a-string/description/
    internal class Program
    {
        static void Main(string[] args)
        {
            MaxScore("011101");
            MaxScore("00111");
            MaxScore("1111");
        }

        public static int MaxScore(string s)
        {
            int maxScore = int.MinValue;
            for (int i = 1; i < s.Length; i++)
            {
                string left = s.Substring(0, i);
                string right = s.Substring(i);
                int l_score = left.Count(c => c == '0');
                int r_score = right.Count(c => c == '1');
                int score = l_score + r_score;
                if (score > maxScore)
                    maxScore = score;
            }

            return maxScore;
        }
    }
}
