using LeetCode;

namespace Problem_24
{
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
