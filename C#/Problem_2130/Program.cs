namespace Problem_2130
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

    // 2130. Maximum Twin Sum of a Linked List
    // https://leetcode.com/problems/maximum-twin-sum-of-a-linked-list/
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode head1 = new ListNode(5);
            head1.next = new ListNode(4);
            head1.next.next = new ListNode(2);
            head1.next.next.next = new ListNode(1);
            PairSum(head1);

            ListNode head2 = new ListNode(4);
            head2.next = new ListNode(2);
            head2.next.next = new ListNode(2);
            head2.next.next.next = new ListNode(3);
            PairSum(head2);
        }

        public static int PairSum(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;
            while (fast != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            ListNode rev = ReverseList(slow);
            int max = int.MinValue;
            while (rev != null)
            {
                int sum = head.val + rev.val;
                if (sum > max)
                    max = sum;

                head = head.next;
                rev = rev.next;
            }

            return max;
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
