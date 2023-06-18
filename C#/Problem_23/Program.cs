namespace Problem_23
{
    //Definition for singly-linked list.
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

    // 23. Merge k Sorted Lists
    // https://leetcode.com/problems/merge-k-sorted-lists/
    internal class Program
    {
        public static ListNode MergeKLists(ListNode[] lists)
        {
            ListNode mergedList = null;
            ListNode head = null;

            if (lists == null || lists.Length == 0)
                return mergedList;

            head = lists[0];
            mergedList = head;

            for (int i = 1; i < lists.Length; i++)
            {
                ListNode currentList = lists[i];

                if (mergedList == null)
                {
                    mergedList = currentList;
                    continue;
                }

                ListNode previous = null;
                ListNode current = mergedList;

                while (current != null && currentList != null)
                {
                    if (current.val <= currentList.val)
                    {
                        previous = current;
                        current = current.next;
                    }
                    else
                    {
                        if (previous != null)
                        {
                            previous.next = currentList;
                        }
                        else
                        {
                            mergedList = currentList;
                        }

                        ListNode nextNode = currentList.next;
                        currentList.next = current;
                        previous = currentList;
                        currentList = nextNode;
                    }
                }

                if (currentList != null)
                {
                    previous.next = currentList;
                }
            }

            return mergedList;
        }

        static void Main(string[] args)
        {
            ListNode head1 = new ListNode(1);
            head1.next = new ListNode(4);
            head1.next.next = new ListNode(5);

            ListNode head2 = new ListNode(1);
            head2.next = new ListNode(3);
            head2.next.next = new ListNode(4);

            ListNode head3 = new ListNode(2);
            head3.next = new ListNode(6);

            ListNode head4 = new ListNode(1);

            ListNode[] lists = { null, head4 };
            ListNode list = MergeKLists(lists);
        }
    }
}
