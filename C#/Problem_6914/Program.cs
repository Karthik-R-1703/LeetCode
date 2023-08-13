using System.Text;

namespace Problem_6914
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

    // 6914. Double a Number Represented as a Linked List
    // 2816. Double a Number Represented as a Linked List
    // https://leetcode.com/problems/double-a-number-represented-as-a-linked-list/
    internal class Program
    {
        public static ListNode DoubleIt(ListNode head)
        {
            StringBuilder str_num = new StringBuilder();
            while (head != null)
            {
                str_num.Append(head.val);
                head = head.next;
            }

            ListNode prev = null;
            int carry = 0;
            for (int i = str_num.Length - 1; i >= 0; i--)
            {
                ListNode cur = new ListNode();
                int val = int.Parse(str_num[i].ToString());
                val *= 2;
                if (val <= 9)
                {
                    cur.val = val + carry;
                    carry = 0;
                }
                else
                {
                    cur.val = (val % 10) + carry;
                    carry = 1;
                }

                cur.next = prev;
                prev = cur;
            }

            if (carry == 0)
            {
                return prev;
            }
            else
            {
                return new ListNode(carry, prev);
            }
        }

        static void Main(string[] args)
        {
            ListNode head1 = new ListNode(1);
            head1.next = new ListNode(8);
            head1.next.next = new ListNode(9);
            DoubleIt(head1);

            ListNode head2 = new ListNode(9);
            head2.next = new ListNode(9);
            head2.next.next = new ListNode(9);
            DoubleIt(head2);
        }
    }
}
