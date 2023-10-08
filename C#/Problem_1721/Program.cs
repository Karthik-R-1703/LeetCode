using System.Collections.Generic;

namespace Problem_1721
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

    // 1721. Swapping Nodes in a Linked List
    // https://leetcode.com/problems/swapping-nodes-in-a-linked-list/description/
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public ListNode SwapNodes(ListNode head, int k)
        {
            List<ListNode> listNodes = new List<ListNode>();
            ListNode node = head;
            while (node != null)
            {
                listNodes.Add(node);
                node = node.next;
            }

            ListNode node_1 = listNodes[k - 1];
            ListNode node_2 = listNodes[listNodes.Count - k];

            (node_1.val, node_2.val) = (node_2.val, node_1.val);

            return head;
        }
    }
}
