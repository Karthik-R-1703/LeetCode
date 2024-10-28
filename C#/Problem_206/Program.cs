using LeetCode;

namespace Problem_206
{
    // 206. Reverse Linked List
    // https://leetcode.com/problems/reverse-linked-list/
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode head1 = new ListNode(1);
            head1.next = new ListNode(2);
            head1.next.next = new ListNode(3);
            head1.next.next.next = new ListNode(4);
            head1.next.next.next.next = new ListNode(5);
            ReverseList(head1);

            ListNode head2 = new ListNode(1);
            head2.next = new ListNode(2);
            ReverseList(head2);

            ListNode head3 = null;
            ReverseList(head3);
        }

        public static ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            ListNode curr = head;
            ListNode prev = null;
            while (curr != null)
            {
                ListNode next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }

            return prev;
        }
    }
}
