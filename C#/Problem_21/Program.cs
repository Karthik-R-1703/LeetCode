using LeetCode;

namespace Problem_21
{
    // 21. Merge Two Sorted Lists
    // https://leetcode.com/problems/merge-two-sorted-lists/
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode list1 = new ListNode(1);
            list1.next = new ListNode(2);
            list1.next.next = new ListNode(4);
            ListNode list2 = new ListNode(1);
            list2.next = new ListNode(3);
            list2.next.next = new ListNode(4);
            MergeTwoLists(list1, list2);

            ListNode list3 = null;
            ListNode list4 = null;
            MergeTwoLists(list3, list4);

            ListNode list5 = null;
            ListNode list6 = new ListNode();
            MergeTwoLists(list5, list6);
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
    }
}
