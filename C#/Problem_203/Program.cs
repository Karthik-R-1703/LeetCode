using LeetCode;

namespace Problem_203
{
    // 203. Remove Linked List Elements
    // https://leetcode.com/problems/remove-linked-list-elements/
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode head1 = new ListNode(1);
            head1.next = new ListNode(2);
            head1.next.next = new ListNode(6);
            head1.next.next.next = new ListNode(3);
            head1.next.next.next.next = new ListNode(4);
            head1.next.next.next.next.next = new ListNode(5);
            head1.next.next.next.next.next.next = new ListNode(6);
            RemoveElements(head1, 6);

            RemoveElements(null, 1);

            ListNode head2 = new ListNode(7);
            head2.next = new ListNode(7);
            head2.next.next = new ListNode(7);
            head2.next.next.next = new ListNode(7);
            RemoveElements(head2, 7);

            ListNode head3 = new ListNode(1);
            head3.next = new ListNode(2);
            head3.next.next = new ListNode(2);
            head3.next.next.next = new ListNode(1);
            RemoveElements(head3, 2);
        }

        public static ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null)
            {
                return null;
            }

            ListNode cur = head;
            ListNode prev = null;
            while (cur != null)
            {
                if (cur.val == val)
                {
                    if (prev == null)
                    {
                        head = head.next;
                        cur = cur.next;
                    }
                    else
                    {
                        while (cur.next != null && cur.next.val == val)
                            cur = cur.next;

                        ListNode nect = cur.next;
                        prev.next = nect;

                        prev = cur;
                        cur = cur.next;
                    }
                }
                else
                {
                    prev = cur;
                    cur = cur.next;
                }
            }

            return head;
        }
    }
}
