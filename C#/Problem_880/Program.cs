using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_880
{
    public class Node
    {
        public string Value = string.Empty;

        public Node Next;

        public Node(string value, Node next)
        {
            Value = value;
            Next = next;
        }
    }

    // 880. Decoded String at Index
    // https://leetcode.com/problems/decoded-string-at-index/description/
    internal class Program
    {
        public static string DecodeAtIndex(string s, int k)
        {
            Node head = null;
            Node tail = null;

            StringBuilder temp = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    string str = temp.ToString();
                    temp.Clear();
                    int count = s[i] - '0';
                }
                else
                {
                    temp.Append(s[i]);
                }
            }

            return string.Empty;
        }

        static void Main(string[] args)
        {
            DecodeAtIndex("leet2code3", 10);
            DecodeAtIndex("ha22", 5);
            DecodeAtIndex("a2345678999999999999999", 1);
            DecodeAtIndex("y959q969u3hb22odq595", 222280369);
        }
    }
}
