using System.Collections.Generic;
using System.Linq;

namespace Problem_8040
{
    // 8040. Minimum Operations to Make a Special Number
    // 2844. Minimum Operations to Make a Special Number
    // https://leetcode.com/problems/minimum-operations-to-make-a-special-number/
    internal class Program
    {
        static void Main(string[] args)
        {
            MinimumOperations("2245047");
            MinimumOperations("2908305");
            MinimumOperations("10");
            MinimumOperations("1");
            MinimumOperations("6525479784667");
            MinimumOperations("444937979672347396583725074143");
        }

        public static int MinimumOperations(string num)
        {
            int totalLength = num.Length;
            HashSet<string> PossibleNums = new HashSet<string>();
            for (int i = 0; i < totalLength; i++)
            {
                HashSet<string> temp = new HashSet<string>(PossibleNums);
                foreach (string n in temp)
                {
                    string t = n + num[i];
                    PossibleNums.Add(t);
                }

                PossibleNums.Add(num[i].ToString());
            }

            HashSet<int> numbers = new HashSet<int>();
            numbers.Add(totalLength);
            foreach (string n in PossibleNums)
            {
                long x = long.Parse(n);
                if (x % 25 == 0)
                {
                    numbers.Add(totalLength - n.Length);
                }
            }

            return numbers.Min();
        }
    }
}
