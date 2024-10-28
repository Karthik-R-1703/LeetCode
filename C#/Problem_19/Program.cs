using LeetCode;

namespace Problem_19
{
    // 19. Remove Nth Node From End of List
    // https://leetcode.com/problems/remove-nth-node-from-end-of-list/
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode head1 = new ListNode(1);
            head1.next = new ListNode(2);
            head1.next.next = new ListNode(3);
            head1.next.next.next = new ListNode(4);
            head1.next.next.next.next = new ListNode(5);
            RemoveNthFromEnd(head1, 2);

            ListNode head2 = new ListNode(1);
            RemoveNthFromEnd(head2, 1);

            ListNode head3 = new ListNode(1);
            head3.next = new ListNode(2);
            RemoveNthFromEnd(head3, 1);
        }

        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode slow = head;
            ListNode fast = head;

            for (int i = 0; i < n; i++)
            {
                fast = fast.next;
            }

            if (fast == null)
            {
                return head.next;
            }

            while (fast.next != null)
            {
                slow = slow.next;
                fast = fast.next;
            }

            slow.next = slow.next.next;
            return head;
        }
    }
}
