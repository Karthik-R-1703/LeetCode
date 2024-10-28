using System;
using LeetCode;

namespace Problem_1290
{
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
