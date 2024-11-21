using System;

namespace Problem_1652
{
    // 1652. Defuse the Bomb
    // https://leetcode.com/problems/defuse-the-bomb/description/
    internal class Program
    {
        public static int[] Decrypt(int[] code, int k)
        {
            int n = code.Length;
            int[] decryptedCode = new int[n];
            if (k == 0)
                return decryptedCode;

            for (int i = 0; i < n; i++)
            {
                int start;
                int end;
                if (k > 0)
                {
                    start = i + 1;
                    end = i + k + 1;
                    while (start < end)
                    {
                        decryptedCode[i] += code[start % n];
                        start++;
                    }
                }
                else
                {
                    start = i - Math.Abs(k);
                    end = i;
                    while (start < end)
                    {
                        decryptedCode[i] += code[(start + n) % n];
                        start++;
                    }
                }
            }

            return decryptedCode;
        }

        static void Main(string[] args)
        {
        }
    }
}
