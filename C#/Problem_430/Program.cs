using System.Collections.Generic;

namespace Problem_430
{
    // Definition for a Node.
    public class Node
    {
        public int val;
        public Node prev;
        public Node next;
        public Node child;
    }

    // 430. Flatten a Multilevel Doubly Linked List
    // https://leetcode.com/problems/flatten-a-multilevel-doubly-linked-list/
    internal class Program
    {
        static Node CreateLinkedList(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return null;

            Node head = new Node();
            head.val = arr[0];
            Node curr = head;
            Node prev = null;
            Stack<Node> childStack = new Stack<Node>();

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == -1)
                {
                    if (childStack.Count > 0)
                        prev = childStack.Pop();
                }
                else
                {
                    Node newNode = new Node();
                    newNode.val = arr[i];
                    newNode.prev = prev;
                    if (prev != null)
                        prev.next = newNode;
                    if (head.child == null)
                        head.child = newNode;
                    prev = newNode;

                    if (arr[i] != -1 && arr[i] < 0)
                        childStack.Push(newNode);
                }
            }
            return head;
        }

        public static Node Flatten(Node head)
        {
            if (head == null)
                return null;

            Node cur = head;
            while (cur != null)
            {
                if (cur.child != null)
                {
                    Node next = cur.next;
                    Node child = cur.child;
                    while (child.next != null)
                    {
                        child = child.next;
                    }

                    cur.next = cur.child;
                    cur.child.prev = cur;
                    cur.child = null;
                    if (next != null)
                    {
                        child.next = next;
                        next.prev = child;
                    }
                }

                cur = cur.next;
            }

            return head;
        }

        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6, -1, -1, -1, 7, 8, 9, 10, -1, -1, 11, 12 };
            Node head1 = CreateLinkedList(arr1);
            Flatten(head1);
        }
    }
}
