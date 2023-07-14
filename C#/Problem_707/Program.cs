namespace Problem_707
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

    public class MyLinkedList
    {
        private ListNode myLinkedList = null;

        public MyLinkedList()
        {

        }

        public int Get(int index)
        {
            int i = 0;
            ListNode listNode = myLinkedList;
            while (listNode != null)
            {
                if (i == index)
                    return listNode.val;

                i++;
                listNode = listNode.next;
            }

            return -1;
        }

        public void AddAtHead(int val)
        {
            ListNode head = new ListNode(val, myLinkedList);
            myLinkedList = head;
        }

        public void AddAtTail(int val)
        {
            if (myLinkedList == null)
            {
                myLinkedList = new ListNode(val);
            }
            else
            {
                ListNode listNode = myLinkedList;
                while (listNode.next != null)
                {
                    listNode = listNode.next;
                }

                ListNode tail = new ListNode(val);
                listNode.next = tail;
            }
        }

        public void AddAtIndex(int index, int val)
        {
            if (index == 0)
            {
                ListNode newNode = new ListNode(val, myLinkedList);
                myLinkedList = newNode;
            }
            else
            {
                int i = 0;
                ListNode listNode = myLinkedList;
                ListNode prev = null;
                while (listNode != null)
                {
                    if (i == index)
                    {
                        ListNode newNode = new ListNode(val, listNode);
                        prev.next = newNode;
                        return;
                    }

                    i++;
                    prev = listNode;
                    listNode = listNode.next;
                }

                if (i == index)
                {
                    ListNode newNode = new ListNode(val);
                    prev.next = newNode;
                }
            }
        }

        public void DeleteAtIndex(int index)
        {
            if (index <= 0 && myLinkedList != null)
            {
                myLinkedList = myLinkedList.next;
            }
            else
            {
                int i = 0;
                ListNode listNode = myLinkedList;
                ListNode prev = null;
                while (listNode != null)
                {
                    if (i == index)
                    {
                        prev.next = listNode.next;
                        return;
                    }

                    i++;
                    prev = listNode;
                    listNode = listNode.next;
                }
            }
        }
    }

    /**
     * Your MyLinkedList object will be instantiated and called as such:
     * MyLinkedList obj = new MyLinkedList();
     * int param_1 = obj.Get(index);
     * obj.AddAtHead(val);
     * obj.AddAtTail(val);
     * obj.AddAtIndex(index,val);
     * obj.DeleteAtIndex(index);
     */

    // 707. Design Linked List
    // https://leetcode.com/problems/design-linked-list/
    internal class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList myLinkedList = new MyLinkedList();
            myLinkedList.AddAtHead(1);
            myLinkedList.AddAtTail(3);
            myLinkedList.AddAtIndex(1, 2);    // linked list becomes 1->2->3
            myLinkedList.Get(1);              // return 2
            myLinkedList.DeleteAtIndex(1);    // now the linked list is 1->3
            myLinkedList.Get(1);              // return 3

            MyLinkedList myLinkedList2 = new MyLinkedList();
            myLinkedList2.AddAtHead(1);
            myLinkedList2.DeleteAtIndex(0);

            MyLinkedList myLinkedList3 = new MyLinkedList();
            myLinkedList3.AddAtHead(7);
            myLinkedList3.AddAtHead(2);
            myLinkedList3.AddAtHead(1);
            myLinkedList3.AddAtIndex(3, 0);
            myLinkedList3.DeleteAtIndex(2);
            myLinkedList3.AddAtHead(6);
            myLinkedList3.AddAtTail(4);
            myLinkedList3.Get(4);
            myLinkedList3.AddAtHead(4);
            myLinkedList3.AddAtIndex(5, 0);
            myLinkedList3.AddAtHead(6);

            MyLinkedList myLinkedList4 = new MyLinkedList();
            myLinkedList4.AddAtIndex(0, 10);
            myLinkedList4.AddAtIndex(0, 20);
            myLinkedList4.AddAtIndex(1, 30);
            myLinkedList4.Get(0);

            MyLinkedList myLinkedList5 = new MyLinkedList();
            myLinkedList5.AddAtTail(1);
            myLinkedList5.Get(0);
        }
    }
}
