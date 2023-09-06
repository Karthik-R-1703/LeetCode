using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_138
{
    // Definition for a Node.
    public class Node
    {
        public int val;
        public Node next;
        public Node random;

        public Node(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }

    // 138. Copy List with Random Pointer
    // https://leetcode.com/problems/copy-list-with-random-pointer/
    internal class Program
    {
        public static Node CopyRandomList(Node head)
        {
            if (head == null)
                return null;

            Node cur = head;
            while (cur != null)
            {
                cur = cur.next;
            }

            return cur;
        }

        static void Main(string[] args)
        {
        }
    }
}
