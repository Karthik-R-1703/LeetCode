using System;
using System.Linq;
using LeetCode;

namespace Problem_234
{
    // 234. Palindrome Linked List
    // https://leetcode.com/problems/palindrome-linked-list/
    internal class Program
    {
        public static bool IsPalindrome(ListNode head)
        {
            string num = string.Empty;

            while (head != null)
            {
                num += head.val.ToString();
                head = head.next;
            }

            string rev = new string(num.Reverse().ToArray());
            return String.Compare(num, rev) == 0;
        }

        static void Main(string[] args)
        {
            ListNode listNode1 = new ListNode(1);
            listNode1.next = new ListNode(2);
            listNode1.next.next = new ListNode(2);
            listNode1.next.next.next = new ListNode(1);
            IsPalindrome(listNode1);
        }
    }
}
