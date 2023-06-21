using System.Net.NetworkInformation;

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
            int sum = Convert_List_to_Num(l1) + Convert_List_to_Num(l2);

            return Convert_Num_to_List(sum);
        }

        public static int Convert_List_to_Num(ListNode l)
        {
            int val = 0;

            while (l != null)
            {
                val = (val * 10) + l.val;
                l = l.next;
            }

            int revVal = 0;

            while (val > 0)
            {
                int r = val % 10;
                revVal = (revVal * 10) + r;
                val /= 10;
            }

            return revVal;
        }

        public static ListNode Convert_Num_to_List(int val)
        {
            ListNode l = new ListNode();
            ListNode head = l;

            while (val > 0)
            {
                int num = val % 10;
                val /= 10;

                head.val = num;
                if (val / 10 > 0)
                {
                    head.next = new ListNode();
                }
                else
                {
                    head.next = null;
                }

                head = head.next;
            }

            return l;
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
        }
    }
}
