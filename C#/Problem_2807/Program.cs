namespace Problem_2807
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

    // 2807. Insert Greatest Common Divisors in Linked List
    // https://leetcode.com/problems/insert-greatest-common-divisors-in-linked-list/
    internal class Program
    {
        public static int GCD(int a, int b)
        {
            while (b != 0)
            {
                (a, b) = (b, a % b);
            }

            return a;
        }

        public static ListNode InsertGreatestCommonDivisors(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            ListNode cur = head;
            while (cur != null)
            {
                if (cur.next != null)
                {
                    ListNode next = cur.next;
                    int num = GCD(cur.val, next.val);
                    cur.next = new ListNode(num, next);
                    cur = next;
                }
                else
                    break;
            }

            return head;
        }

        static void Main(string[] args)
        {
            ListNode head = new ListNode(18);
            head.next = new ListNode(6);
            head.next.next = new ListNode(10);
            head.next.next.next = new ListNode(3);
            InsertGreatestCommonDivisors(head);
        }
    }
}
