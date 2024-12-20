﻿using LeetCode;

namespace Problem_61
{
    // 61. Rotate List
    // https://leetcode.com/problems/rotate-list/
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static ListNode RotateRight(ListNode head, int k)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode temp = head;
            int Length = 0;
            while (temp != null)
            {
                temp = temp.next;
                Length++;
            }

            k %= Length;

            while (k > 0)
            {
                ListNode cur = head;
                while (cur.next.next != null)
                {
                    cur = cur.next;
                }

                ListNode last = cur.next;
                last.next = head;
                cur.next = null;
                head = last;
                k--;
            }

            return head;
        }
    }
}
