using System.Collections.Generic;

namespace Problem_3217
{
    // 3217. Delete Nodes From Linked List Present in Array
    // https://leetcode.com/problems/delete-nodes-from-linked-list-present-in-array/description/

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
