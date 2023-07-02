using System.Collections.Generic;

namespace Problem_66
{
    // 66. Plus One
    // https://leetcode.com/problems/plus-one/
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> digits;

            digits = new List<int>() { 1, 2, 3 };
            PlusOne(digits.ToArray());

            digits = new List<int>() { 4, 3, 2, 1 };
            PlusOne(digits.ToArray());

            digits = new List<int>() { 9 };
            PlusOne(digits.ToArray());

            digits = new List<int>() { 9, 1, 9 };
            PlusOne(digits.ToArray());
        }

        public static int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] != 9)
                {
                    digits[i]++;
                    return digits;
                }

                digits[i] = 0;
            }

            int[] carry = new int[digits.Length + 1];
            carry[0] = 1;

            return carry;
        }
    }
}
