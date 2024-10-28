using System;
using LeetCode;

namespace Problem_104
{
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
