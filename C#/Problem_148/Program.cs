namespace Problem_148
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

    // 148. Sort List
    // https://leetcode.com/problems/sort-list/
    internal class Program
    {
        public static ListNode Divide(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head.next;
            while (fast != null && fast.next != null)
            {
                slow = slow?.next;
                head = head?.next;
                fast = fast.next?.next;
            }

            ListNode mid = slow.next;
            head.next = null;
            return mid;
        }

        static void Main(string[] args)
        {
            ListNode head = new ListNode(4);
            head.next = new ListNode(2);
            head.next.next = new ListNode(1);
            head.next.next.next = new ListNode(3);
            ListNode result = SortList(head);
        }

        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null && list2 == null)
                return null;
            else if (list1 == null)
                return list2;
            else if (list2 == null)
                return list1;

            ListNode dummy = new ListNode();
            ListNode current = dummy;

            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }

                current = current.next;
            }

            if (list1 != null)
                current.next = list1;
            else if (list2 != null)
                current.next = list2;

            return dummy.next;
        }

        public static ListNode SortList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode mid = Divide(head);

            head = SortList(head);
            mid = SortList(mid);

            ListNode result = MergeTwoLists(head, mid);

            return result;
        }
    }
}
