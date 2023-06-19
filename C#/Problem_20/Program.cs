using System.Collections.Generic;

namespace Problem_20
{
    // 20. Valid Parentheses
    // https://leetcode.com/problems/valid-parentheses/
    internal class Program
    {
        public bool IsValid(string s)
        {
            Stack<char> Parentheses = new Stack<char>();
            foreach (char str in s)
            {
                switch (str)
                {
                    case '(':
                    case '[':
                    case '{':
                        Parentheses.Push(str);
                        break;
                    case ')':
                        if (Parentheses.Count == 0 || Parentheses.Peek() != '(')
                        {
                            return false;
                        }

                        Parentheses.Pop();
                        break;
                    case ']':
                        if (Parentheses.Count == 0 || Parentheses.Peek() != '[')
                        {
                            return false;
                        }

                        Parentheses.Pop();
                        break;
                    case '}':
                        if (Parentheses.Count == 0 || Parentheses.Peek() != '{')
                        {
                            return false;
                        }

                        Parentheses.Pop();
                        break;
                    default:
                        break;
                }
            }

            return Parentheses.Count == 0;
        }

        static void Main(string[] args)
        {
        }
    }
}
