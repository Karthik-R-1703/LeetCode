using LeetCode;

namespace Problem_83
{
    // 83. Remove Duplicates from Sorted List
    // https://leetcode.com/problems/remove-duplicates-from-sorted-list/
    internal class Program
    {
        public static ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null)
                return null;

            ListNode cur = head;
            while (cur != null && cur.next != null)
            {
                while (cur.next != null && cur.val == cur.next.val)
                {
                    cur.next = cur.next.next;
                }

                cur = cur.next;
            }

            return head;
        }

        static void Main(string[] args)
        {
            ListNode head1 = new ListNode(1);
            head1.next = new ListNode(1);
            head1.next.next = new ListNode(2);
            DeleteDuplicates(head1);

            ListNode head2 = new ListNode(1);
            head2.next = new ListNode(1);
            head2.next.next = new ListNode(2);
            head2.next.next.next = new ListNode(3);
            head2.next.next.next.next = new ListNode(3);
            DeleteDuplicates(head2);
        }
    }
}
