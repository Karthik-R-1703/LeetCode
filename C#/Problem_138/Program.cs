using System.Collections.Generic;

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
            Dictionary<Node, Node> Copy = new Dictionary<Node, Node>();
            while (cur != null)
            {
                Copy.Add(cur, new Node(cur.val));
                cur = cur.next;
            }

            cur = head;
            while (cur != null)
            {
                if (cur.next != null)
                    Copy[cur].next = Copy[cur.next];

                if (cur.random != null)
                    Copy[cur].random = Copy[cur.random];

                cur = cur.next;
            }

            return Copy[head];
        }

        static void Main(string[] args)
        {
        }
    }
}
