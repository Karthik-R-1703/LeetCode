using System;

namespace Problem_143
{
    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public void ReorderList(ListNode head)
        {
            if (head == null || head.next == null)
                return;

            ListNode slow = head;
            ListNode fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            ListNode prev = null;
            ListNode curr = slow;
            while (curr != null)
            {
                ListNode nextNode = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nextNode;
            }

            ListNode first = head;
            ListNode second = prev;
            while (second.next != null)
            {
                ListNode nextFirst = first.next;
                ListNode nextSecond = second.next;
                first.next = second;
                second.next = nextFirst;
                first = nextFirst;
                second = nextSecond;
            }
        }
    }

    // 143. Reorder List
    // https://leetcode.com/problems/reorder-list/
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode head1 = new ListNode(1);
            head1.next = new ListNode(2);
            head1.next.next = new ListNode(3);
            head1.next.next.next = new ListNode(4);

            head1.ReorderList(head1);

            ListNode node1 = head1;
            while (node1 != null)
            {
                Console.Write(node1.val + " ");
                node1 = node1.next;
            }

            Console.WriteLine();

            ListNode head2 = new ListNode(1);
            head2.next = new ListNode(2);
            head2.next.next = new ListNode(3);
            head2.next.next.next = new ListNode(4);
            head2.next.next.next.next = new ListNode(5);

            head2.ReorderList(head2);

            ListNode node2 = head2;
            while (node2 != null)
            {
                Console.Write(node2.val + " ");
                node2 = node2.next;
            }
        }
    }
}
