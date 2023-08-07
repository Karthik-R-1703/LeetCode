namespace Problem_6
{
    // 6. Zigzag Conversion
    // https://leetcode.com/problems/zigzag-conversion/
    internal class Program
    {
        public static string Convert(string s, int numRows)
        {
            if (numRows == 1)
                return s;

            string[] result = new string[numRows];
            int i = 0;
            bool frwd = true;
            foreach (char c in s)
            {
                if (result[i] == null)
                    result[i] = string.Empty;

                result[i] += c;
                if (frwd)
                {
                    i++;
                }
                else
                {
                    i--;
                }

                if (i == numRows - 1 || i == 0)
                    frwd = !frwd;
            }

            return string.Join(string.Empty, result);
        }

        static void Main(string[] args)
        {
            Convert("PAYPALISHIRING", 3);
            Convert("PAYPALISHIRING", 4);
            Convert("A", 1);
            Convert("AB", 1);
        }
    }
}
