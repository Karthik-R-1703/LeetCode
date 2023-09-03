using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_116
{
    // Definition for a Node.
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }

    // 116. Populating Next Right Pointers in Each Node
    // https://leetcode.com/problems/populating-next-right-pointers-in-each-node/
    internal class Program
    {
        public static Node Connect(Node root)
        {
            return root;
        }

        static void Main(string[] args)
        {
        }
    }
}
