using System.Text;

namespace Problem_12
{
    // 12. Integer to Roman
    // https://leetcode.com/problems/integer-to-roman/
    internal class Program
    {
        public static string IntToRoman(int num)
        {
            string[] thousands = { "", "M", "MM", "MMM" };
            string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            StringBuilder RomanString = new StringBuilder();
            RomanString.Append(thousands[num / 1000]);
            num %= 1000;
            RomanString.Append(hundreds[num / 100]);
            num %= 100;
            RomanString.Append(tens[num / 10]);
            num %= 10;
            RomanString.Append(ones[num]);
            return RomanString.ToString();
        }

        static void Main(string[] args)
        {
            IntToRoman(3);
            IntToRoman(58);
            IntToRoman(1994);
        }
    }
}
