using LeetCode;

namespace Problem_2181
{
    // 2181. Merge Nodes in Between Zeros
    // https://leetcode.com/problems/merge-nodes-in-between-zeros/
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode head1 = new ListNode(0);
            head1.next = new ListNode(3);
            head1.next.next = new ListNode(1);
            head1.next.next.next = new ListNode(0);
            head1.next.next.next.next = new ListNode(4);
            head1.next.next.next.next.next = new ListNode(5);
            head1.next.next.next.next.next.next = new ListNode(2);
            head1.next.next.next.next.next.next.next = new ListNode(0);
            MergeNodes(head1);
        }

        public static ListNode MergeNodes(ListNode head)
        {
            ListNode result = new ListNode();
            ListNode prev = result;
            while (head != null)
            {
                while (head != null && head.val == 0)
                {
                    head = head.next;
                }

                if (head != null)
                {
                    int num = 0;
                    while (head != null && head.val != 0)
                    {
                        num += head.val;
                        head = head.next;
                    }

                    ListNode cur = new ListNode(num);
                    prev.next = cur;
                    prev = cur;
                }
            }

            return result.next;
        }
    }
}
