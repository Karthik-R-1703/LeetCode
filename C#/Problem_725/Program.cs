namespace Problem_725
{
    // 725. Split Linked List in Parts
    // https://leetcode.com/problems/split-linked-list-in-parts/description/

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

        public static ListNode[] SplitListToParts(ListNode head, int k)
        {
            ListNode[] listNodes = new ListNode[k];
            int n = 0;
            ListNode curNode = head;
            while (curNode != null)
            {
                n++;
                curNode = curNode.next;
            }

            int s_n = n / k;
            int m_n = n % k;
            curNode = head;
            for (int i = 0; i < k; i++)
            {
                ListNode newNode = new ListNode(0);
                ListNode tempNode = newNode;
                int c_n = s_n;
                if (m_n > 0)
                {
                    m_n--;
                    c_n++;
                }

                int j = 0;
                while (j < c_n)
                {
                    tempNode.next = new ListNode(curNode.val);
                    tempNode = tempNode.next;
                    j++;
                    curNode = curNode.next;
                }

                listNodes[i] = newNode.next;
            }

            return listNodes;
        }
    }
}
