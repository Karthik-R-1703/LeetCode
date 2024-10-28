using LeetCode;

namespace Problem_86
{
    // 86. Partition List
    // https://leetcode.com/problems/partition-list/
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public ListNode Partition(ListNode head, int x)
        {
            if (head == null)
            {
                return null;
            }

            ListNode minNode = new ListNode();
            ListNode maxNode = new ListNode();

            ListNode cur = head;
            ListNode cur_minNode = minNode;
            ListNode cur_maxNode = maxNode;

            while (cur != null)
            {
                if (cur.val < x)
                {
                    cur_minNode.next = cur;
                    cur_minNode = cur_minNode.next;
                }
                else
                {
                    cur_maxNode.next = cur;
                    cur_maxNode = cur_maxNode.next;
                }

                cur = cur.next;
            }

            cur_maxNode.next = null;
            cur_minNode.next = maxNode.next;

            return minNode.next;
        }
    }
}
