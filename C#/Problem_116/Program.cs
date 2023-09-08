using System.Collections.Generic;

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
            if (root == null)
                return null;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                Queue<Node> level = new Queue<Node>();
                while (queue.Count > 0)
                {
                    Node node = queue.Dequeue();

                    if (node.left != null)
                        level.Enqueue(node.left);

                    if (node.right != null)
                        level.Enqueue(node.right);
                }

                while (level.Count > 0)
                {
                    Node node = level.Dequeue();
                    queue.Enqueue(node);

                    if (level.Count > 0)
                        node.next = level.Peek();
                }
            }

            return root;
        }

        static void Main(string[] args)
        {
        }
    }
}
