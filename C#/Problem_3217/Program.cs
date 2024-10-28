using System.Collections.Generic;
using LeetCode;

namespace Problem_3217
{
    // 3217. Delete Nodes From Linked List Present in Array
    // https://leetcode.com/problems/delete-nodes-from-linked-list-present-in-array/description/
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public ListNode ModifiedList(int[] nums, ListNode head)
        {
            HashSet<int> uniqueNums = new HashSet<int>(nums);
            while (head != null && uniqueNums.Contains(head.val))
                head = head.next;

            if (head == null)
                return null;

            ListNode curNode = head;
            while (curNode.next != null)
            {
                if (uniqueNums.Contains(curNode.next.val))
                    curNode.next = curNode.next.next;
                else
                    curNode = curNode.next;
            }

            return head;
        }
    }
}
