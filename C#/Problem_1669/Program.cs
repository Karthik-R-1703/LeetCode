namespace Problem_1669
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

    // 1669. Merge In Between Linked Lists
    // https://leetcode.com/problems/merge-in-between-linked-lists/description/
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2)
        {
            int i = 0;
            ListNode listNode = list1;
            while (i < a - 1)
            {
                listNode = listNode.next;
                i++;
            }

            ListNode start = listNode;
            while (i <= b)
            {
                listNode = listNode.next;
                i++;
            }

            ListNode end = listNode;
            listNode = list2;
            while (listNode.next != null)
            {
                listNode = listNode.next;
            }

            start.next = list2;
            listNode.next = end;
            return list1;
        }
    }
}
