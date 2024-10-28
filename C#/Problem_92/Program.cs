using System;
using LeetCode;

namespace Problem_92
{
    // 92. Reverse Linked List II
    // https://leetcode.com/problems/reverse-linked-list-ii/
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode listNode8 = new ListNode(8);
            ListNode listNode7 = new ListNode(7, listNode8);
            ListNode listNode6 = new ListNode(6, listNode7);
            ListNode listNode5 = new ListNode(5, listNode6);
            ListNode listNode4 = new ListNode(4, listNode5);
            ListNode listNode3 = new ListNode(3, listNode4);
            ListNode listNode2 = new ListNode(2, listNode3);
            ListNode listNode1 = new ListNode(1, listNode2);

            ListNode result = ReverseBetween(listNode1, 3, 6);
            Console.ReadKey();
        }

        public static ListNode ReverseBetween(ListNode head, int left, int right)
        {
            if (head == null || left == right)
            {
                return head;
            }

            ListNode dummy = head;

            ListNode preLeft = dummy;

            for (int i = 2; i < left; i++)
            {
                preLeft = preLeft.next;
            }

            ListNode curr = preLeft.next;
            ListNode prev = null;
            ListNode next = null;
            ListNode leftNode = curr;

            for (int i = left; i <= right; i++)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }

            preLeft.next = prev;
            leftNode.next = curr;

            return dummy;
        }
    }
}
