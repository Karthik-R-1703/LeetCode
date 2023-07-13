using System.Collections.Generic;

namespace Problem_202
{
    // 202. Happy Number
    // https://leetcode.com/problems/happy-number/
    internal class Program
    {
        public static bool IsHappy(int n)
        {
            HashSet<int> visited = new HashSet<int>();
            while (true)
            {
                int sum = 0;
                while (n > 0)
                {
                    sum += (n % 10) * (n % 10);
                    n /= 10;
                }

                n = sum;
                if (n == 1)
                {
                    return true;
                }
                else if (visited.Contains(n))
                {
                    return false;
                }
                else
                {
                    visited.Add(n);
                }
            }
        }

        static void Main(string[] args)
        {
            IsHappy(19);
            IsHappy(2);
        }
    }
}
