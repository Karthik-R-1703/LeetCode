namespace Problem_328
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

    // 328. Odd Even Linked List
    // https://leetcode.com/problems/odd-even-linked-list/
    internal class Program
    {
        static void Main(string[] args)
        {
            OddEvenList(null);
            OddEvenList(new ListNode(1));
            OddEvenList(new ListNode(1, new ListNode(2)));
            OddEvenList(new ListNode(1, new ListNode(2, new ListNode(3))));

            ListNode head1 = new ListNode(1);
            head1.next = new ListNode(2);
            head1.next.next = new ListNode(3);
            head1.next.next.next = new ListNode(4);
            head1.next.next.next.next = new ListNode(5);
            OddEvenList(head1);

            ListNode head2 = new ListNode(2);
            head2.next = new ListNode(1);
            head2.next.next = new ListNode(3);
            head2.next.next.next = new ListNode(5);
            head2.next.next.next.next = new ListNode(6);
            head2.next.next.next.next.next = new ListNode(4);
            head2.next.next.next.next.next.next = new ListNode(7);
            OddEvenList(head2);

            ListNode head3 = new ListNode(1);
            head3.next = new ListNode(2);
            head3.next.next = new ListNode(3);
            head3.next.next.next = new ListNode(4);
            head3.next.next.next.next = new ListNode(5);
            head3.next.next.next.next.next = new ListNode(6);
            head3.next.next.next.next.next.next = new ListNode(7);
            head3.next.next.next.next.next.next.next = new ListNode(8);
            OddEvenList(head3);
        }

        public static ListNode OddEvenList(ListNode head)
        {
            if (head == null || head.next == null || head.next.next == null)
            {
                return head;
            }

            ListNode odd = head;
            ListNode even = head.next;
            ListNode evenStart = head.next;

            while (odd.next != null && even.next != null)
            {
                odd.next = even.next;
                odd = odd.next;

                even.next = odd.next;
                even = even.next;
            }

            odd.next = evenStart;
            return head;
        }
    }
}
