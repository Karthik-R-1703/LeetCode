using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_20
{
    // 20. Valid Parentheses
    // https://leetcode.com/problems/valid-parentheses/
    internal class Program
    {
        public bool IsValid(string s)
        {
            Stack<char> Parentheses = new Stack<char>();
            foreach (char str in s.ToArray())
            {
                switch (str)
                {
                    case '(':
                        Parentheses.Push(str);
                        break;
                    case ')':
                        Parentheses.Pop();
                        break;
                    case '[':
                        Parentheses.Push(str);
                        break;
                    case ']':
                        Parentheses.Pop();
                        break;
                    case '{':
                        Parentheses.Push(str);
                        break;
                    case '}':
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
