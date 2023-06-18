using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Problem_150
{
    // 150. Evaluate Reverse Polish Notation
    // https://leetcode.com/problems/evaluate-reverse-polish-notation/
    internal class Program
    {
        public int EvalRPN(string[] tokens)
        {
            Stack<int> stack = new Stack<int>();

            foreach (string token in tokens)
            {
                int number;
                if (int.TryParse(token, out number))
                {
                    stack.Push(number);
                }
                else
                {
                    int num2 = stack.Pop();
                    int num1 = stack.Pop();
                    switch (token)
                    {
                        case "+":
                            stack.Push(num1 + num2);
                            break;
                        case "-":
                            stack.Push(num1 - num2);
                            break;
                        case "*":
                            stack.Push(num1 * num2);
                            break;
                        case "/":
                            stack.Push(num1 / num2);
                            break;
                        default:
                            break;
                    }
                }
            }


            return stack.Peek();
        }

        static void Main(string[] args)
        {
        }
    }
}
