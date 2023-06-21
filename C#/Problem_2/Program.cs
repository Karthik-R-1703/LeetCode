namespace Problem_2
{
    //Definition for singly-linked list.
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

    // 2. Add Two Numbers
    // https://leetcode.com/problems/add-two-numbers/
    internal class Program
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode();
            ListNode head = result;

            int sum = 0;
            while (l1 != null || l2 != null || sum > 0)
            {
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }

                int unitsPlace = sum % 10;
                sum /= 10;

                result.next = new ListNode(unitsPlace);
                result = result.next;
            }

            return head.next;
        }

        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);

            ListNode l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);

            ListNode sum = AddTwoNumbers(l1, l2);

            ListNode l3 = new ListNode(9);
            l3.next = new ListNode(9);
            l3.next.next = new ListNode(9);
            l3.next.next.next = new ListNode(9);
            l3.next.next.next.next = new ListNode(9);
            l3.next.next.next.next.next = new ListNode(9);
            l3.next.next.next.next.next.next = new ListNode(9);

            ListNode l4 = new ListNode(9);
            l4.next = new ListNode(9);
            l4.next.next = new ListNode(9);
            l4.next.next.next = new ListNode(9);
            sum = AddTwoNumbers(l3, l4);

            ListNode l5 = new ListNode(9);

            ListNode l6 = new ListNode(1);
            l6.next = new ListNode(9);
            l6.next.next = new ListNode(9);
            l6.next.next.next = new ListNode(9);
            l6.next.next.next.next = new ListNode(9);
            l6.next.next.next.next.next = new ListNode(9);
            l6.next.next.next.next.next.next = new ListNode(9);
            l6.next.next.next.next.next.next.next = new ListNode(9);
            l6.next.next.next.next.next.next.next.next = new ListNode(9);
            l6.next.next.next.next.next.next.next.next.next = new ListNode(9);
            sum = AddTwoNumbers(l3, l4);
        }
    }
}
