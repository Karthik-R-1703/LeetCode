using System;

namespace Problem_104
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

    // 104. Maximum Depth of Binary Tree
    // https://leetcode.com/problems/maximum-depth-of-binary-tree/
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode right = new TreeNode(20, new TreeNode(15), new TreeNode(7));
            TreeNode root = new TreeNode(3, new TreeNode(9), right);
            MaxDepth(root);

            MaxDepth(new TreeNode(1, null, new TreeNode(2)));
        }

        public static int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int left_depth = MaxDepth(root.left);
            int right_depth = MaxDepth(root.right);

            return Math.Max(left_depth, right_depth) + 1;
        }
    }
}
