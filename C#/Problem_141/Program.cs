using System.Collections.Generic;
using LeetCode;

namespace Problem_141
{
    // 141. Linked List Cycle
    // https://leetcode.com/problems/linked-list-cycle/
    internal class Program
    {
        public static bool HasCycle(ListNode head)
        {
            // Method 2 : Two-Pointer
            if (head == null || head.next == null)
            {
                return false;
            }

            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                {
                    return true;
                }
            }

            return false;

            // Method 1 : HashSet
            HashSet<ListNode> cycle = new HashSet<ListNode>();
            while (head != null)
            {
                if (cycle.Contains(head))
                    return true;

                cycle.Add(head);
                head = head.next;
            }

            return false;
        }

        static void Main(string[] args)
        {
            ListNode list1 = new ListNode(3);
            list1.next = new ListNode(2);
            list1.next.next = new ListNode(0);
            list1.next.next.next = new ListNode(-4);
            list1.next.next.next.next = list1.next;
            HasCycle(list1);

            ListNode list2 = new ListNode(1);
            list2.next = new ListNode(2);
            list2.next.next = list2;
            HasCycle(list2);

            ListNode list3 = new ListNode(1);
            HasCycle(list3);
        }
    }
}
