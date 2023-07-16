namespace Problem_142
{
    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    // 142. Linked List Cycle II
    // https://leetcode.com/problems/linked-list-cycle-ii/
    internal class Program
    {
        public static ListNode DetectCycle(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return null;
            }

            ListNode slow = head;
            ListNode fast = head;
            bool hasCycle = false;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                {
                    hasCycle = true;
                    break;
                }
            }

            if (!hasCycle)
            {
                return null;
            }

            slow = head;
            while (slow != fast)
            {
                slow = slow.next;
                fast = fast.next;
            }

            return slow;
        }

        static void Main(string[] args)
        {
            ListNode list1 = new ListNode(1);
            list1.next = new ListNode(3);
            list1.next.next = new ListNode(2);
            list1.next.next.next = new ListNode(0);
            list1.next.next.next.next = new ListNode(-4);
            list1.next.next.next.next.next = list1.next.next;
            DetectCycle(list1);

            ListNode list2 = new ListNode(1);
            list2.next = new ListNode(2);
            list2.next.next = list2;
            DetectCycle(list2);

            ListNode list3 = new ListNode(1);
            DetectCycle(list3);
        }
    }
}
