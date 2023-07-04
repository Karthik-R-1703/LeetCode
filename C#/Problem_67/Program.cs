using System;

namespace Problem_67
{
    // 67. Add Binary
    // https://leetcode.com/problems/add-binary/
    internal class Program
    {
        public static string AddBinary(string a, string b)
        {
            string sum = string.Empty;

            int maxLength = Math.Max(a.Length, b.Length);
            a = a.PadLeft(maxLength, '0');
            b = b.PadLeft(maxLength, '0');

            int carry = 0;

            for (int i = maxLength - 1; i >= 0; i--)
            {
                int a_num = int.Parse(a[i].ToString());
                int b_num = int.Parse(b[i].ToString());
                int sum_num = carry + a_num + b_num;
                if (sum_num == 0)
                {
                    sum = sum.Insert(0, "0");
                    carry = 0;
                }
                else if (sum_num == 1)
                {
                    sum = sum.Insert(0, "1");
                    carry = 0;
                }
                else if (sum_num == 2)
                {
                    sum = sum.Insert(0, "0");
                    carry = 1;
                }
                else if (sum_num == 3)
                {
                    sum = sum.Insert(0, "1");
                    carry = 1;
                }
            }

            if (carry == 1)
            {
                sum = sum.Insert(0, "1");
            }

            return sum;
        }

        static void Main(string[] args)
        {
            AddBinary("11", "1");
            AddBinary("1010", "1011");
            AddBinary("1111", "1111");
        }
    }
}
