using System.Collections.Generic;

namespace Problem_1367
{
    // 1367. Linked List in Binary Tree
    // https://leetcode.com/problems/linked-list-in-binary-tree/description/

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
        private static bool IsMatch(ListNode head, TreeNode root)
        {
            Stack<KeyValuePair<TreeNode, ListNode>> s = new Stack<KeyValuePair<TreeNode, ListNode>>();
            s.Push(new KeyValuePair<TreeNode, ListNode>(root, head));
            while (s.Count > 0)
            {
                KeyValuePair<TreeNode, ListNode> entry = s.Pop();
                TreeNode currentNode = entry.Key;
                ListNode currentList = entry.Value;

                while (currentNode != null && currentList != null)
                {
                    if (currentNode.val != currentList.val)
                        break;

                    currentList = currentList.next;
                    if (currentList != null)
                    {
                        if (currentNode.left != null)
                            s.Push(
                                new KeyValuePair<TreeNode, ListNode>(
                                    currentNode.left,
                                    currentList
                                )
                            );

                        if (currentNode.right != null)
                            s.Push(
                                new KeyValuePair<TreeNode, ListNode>(
                                    currentNode.right,
                                    currentList
                                )
                            );

                        break;
                    }
                }

                if (currentList == null)
                    return true;
            }

            return false;
        }

        public static bool IsSubPath(ListNode head, TreeNode root)
        {
            if (root == null)
                return false;

            Stack<TreeNode> nodes = new Stack<TreeNode>();
            nodes.Push(root);

            while (nodes.Count > 0)
            {
                TreeNode node = nodes.Pop();

                if (IsMatch(head, node))
                    return true;

                if (node.left != null)
                    nodes.Push(node.left);

                if (node.right != null)
                    nodes.Push(node.right);
            }

            return false;
        }

        static void Main(string[] args)
        {
        }
    }

    // Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
