using System;

namespace Problem_1290
{
    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    // 1290. Convert Binary Number in a Linked List to Integer
    // https://leetcode.com/problems/convert-binary-number-in-a-linked-list-to-integer/
    internal class Program
    {
        public static int GetDecimalValue(ListNode head)
        {
            string binary = string.Empty;
            while (head != null)
            {
                binary += head.val;
                head = head.next;
            }

            return Convert.ToInt32(binary, 2);
        }

        static void Main(string[] args)
        {
            ListNode head1 = new ListNode(1);
            head1.next = new ListNode(0);
            head1.next.next = new ListNode(1);
            GetDecimalValue(head1);

            GetDecimalValue(new ListNode(0));
        }
    }
}
