namespace Problem_160
{
    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
        }
    }

    // 160. Intersection of Two Linked Lists
    // https://leetcode.com/problems/intersection-of-two-linked-lists/
    internal class Program
    {
        public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null)
            {
                return null;
            }

            ListNode currA = headA;
            ListNode currB = headB;
            while (currA != currB)
            {
                if (currA == null)
                {
                    currA = headB;
                }
                else
                {
                    currA = currA.next;
                }

                if (currB == null)
                {
                    currB = headA;
                }
                else
                {
                    currB = currB.next;
                }
            }

            return currA;
        }

        static void Main(string[] args)
        {
            ListNode a1 = new ListNode(4);
            ListNode a2 = new ListNode(1);
            ListNode b1 = new ListNode(5);
            ListNode b2 = new ListNode(6);
            ListNode b3 = new ListNode(1);
            ListNode c1 = new ListNode(8);
            ListNode c2 = new ListNode(4);
            ListNode c3 = new ListNode(5);

            a1.next = a2;
            a2.next = c1;

            b1.next = b2;
            b2.next = b3;
            b3.next = c1;

            c1.next = c2;
            c2.next = c3;

            GetIntersectionNode(a1, b1);

            ListNode d1 = new ListNode(1);
            ListNode d2 = new ListNode(9);
            ListNode d3 = new ListNode(1);
            ListNode e1 = new ListNode(3);
            ListNode e2 = new ListNode(2);
            ListNode e3 = new ListNode(4);

            d1.next = d2;
            d2.next = d3;

            e1.next = e2;
            e2.next = e3;
            e3.next = d2;

            GetIntersectionNode(d1, e1);

            ListNode f1 = new ListNode(2);
            ListNode f2 = new ListNode(6);
            ListNode f3 = new ListNode(4);
            ListNode g1 = new ListNode(1);
            ListNode g2 = new ListNode(5);

            f1.next = f2;
            f2.next = f3;

            g1.next = g2;

            GetIntersectionNode(f1, g1);
        }
    }
}
