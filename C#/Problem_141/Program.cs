using System.Collections.Generic;

namespace Problem_141
{
    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    // 141. Linked List Cycle
    // https://leetcode.com/problems/linked-list-cycle/
    internal class Program
    {
        public bool HasCycle(ListNode head)
        {
            HashSet<ListNode> cycle = new HashSet<ListNode>();
            while (head != null)
            {
                if (cycle.Contains(head))
                    return true;

                cycle.Add(head);
                head = head.next;
            }

            return false;
        }

        static void Main(string[] args)
        {
        }
    }
}
