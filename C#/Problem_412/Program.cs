using System.Collections.Generic;

namespace Problem_412
{
    // 412. Fizz Buzz
    // https://leetcode.com/problems/fizz-buzz/
    internal class Program
    {
        public IList<string> FizzBuzz(int n)
        {
            List<string> answer = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    answer.Add("FizzBuzz");
                else if (i % 3 == 0)
                    answer.Add("Fizz");
                else if (i % 5 == 0)
                    answer.Add("Buzz");
                else
                    answer.Add(i.ToString());
            }

            return answer;
        }

        static void Main(string[] args)
        {
        }
    }
}
