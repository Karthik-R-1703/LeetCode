using System.Text;

namespace Problem_2129
{
    // 2129. Capitalize the Title
    // https://leetcode.com/problems/capitalize-the-title/
    internal class Program
    {
        public static string CapitalizeTitle(string title)
        {
            StringBuilder answer = new StringBuilder();
            string[] words = title.Split(' ');
            foreach (string word in words)
            {
                if (word.Length <= 2)
                {
                    answer.Append(word.ToLowerInvariant());
                }
                else
                {
                    char[] temp = word.ToLowerInvariant().ToCharArray();
                    temp[0] = char.ToUpper(temp[0]);
                    answer.Append(new string(temp));
                }

                answer.Append(" ");
            }

            return answer.ToString().Trim();
        }

        static void Main(string[] args)
        {
            CapitalizeTitle("capiTalIze tHe titLe");
            CapitalizeTitle("First leTTeR of EACH Word");
            CapitalizeTitle("i lOve leetcode");
        }
    }
}
