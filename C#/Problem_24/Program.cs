namespace Problem_24
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

    // 24. Swap Nodes in Pairs
    // https://leetcode.com/problems/swap-nodes-in-pairs/
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode cur = head;
            ListNode next = head.next;

            cur.next = SwapPairs(next.next);
            next.next = cur;

            return next;
        }
    }
}
