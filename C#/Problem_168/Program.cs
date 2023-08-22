using System.Text;

namespace Problem_168
{
    // 168. Excel Sheet Column Title
    // https://leetcode.com/problems/excel-sheet-column-title/
    internal class Program
    {
        public static string ConvertToTitle(int columnNumber)
        {
            StringBuilder title = new StringBuilder();
            while (columnNumber > 0)
            {
                columnNumber--;
                title.Insert(0, (char)((columnNumber) % 26 + 'A'));
                columnNumber /= 26;
            }

            return title.ToString();
        }

        static void Main(string[] args)
        {
            ConvertToTitle(1);
            ConvertToTitle(28);
            ConvertToTitle(701);
        }
    }
}
