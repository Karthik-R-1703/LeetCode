using LeetCode;

namespace Problem_876
{
    // 876. Middle of the Linked List
    // https://leetcode.com/problems/middle-of-the-linked-list/
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode head1 = new ListNode(1);
            head1.next = new ListNode(2);
            head1.next.next = new ListNode(3);
            head1.next.next.next = new ListNode(4);
            head1.next.next.next.next = new ListNode(5);
            MiddleNode(head1);

            ListNode head2 = new ListNode(1);
            head2.next = new ListNode(2);
            head2.next.next = new ListNode(3);
            head2.next.next.next = new ListNode(4);
            head2.next.next.next.next = new ListNode(5);
            head2.next.next.next.next.next = new ListNode(6);
            MiddleNode(head2);
        }

        public static ListNode MiddleNode(ListNode head)
        {
            if (head == null)
                return null;

            ListNode slow = head;
            ListNode fast = head;
            while (fast != null)
            {
                if (fast.next != null && fast.next.next != null)
                {
                    slow = slow.next;
                    fast = fast.next.next;
                }
                else if (fast.next != null)
                {
                    slow = slow.next;
                    break;
                }
                else
                {
                    break;
                }
            }

            return slow;
        }
    }
}
