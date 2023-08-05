using System;

namespace Problem_110
{
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

    // 110. Balanced Binary Tree
    // https://leetcode.com/problems/balanced-binary-tree/
    internal class Program
    {
        public static bool IsBalanced(TreeNode root)
        {
            if (root == null)
                return false;

            if (Math.Abs(Depth(root.left) - Depth(root.right)) <= 1)
                return true;
            else
                return false;
        }

        public static int Depth(TreeNode root)
        {
            if (root == null)
                return 0;
            else if (root.left == null && root.right == null)
                return 1;

            return Math.Max(Depth(root.left), Depth(root.right)) + 1;
        }

        static void Main(string[] args)
        {
        }
    }
}
