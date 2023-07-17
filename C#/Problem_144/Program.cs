using System.Collections.Generic;

namespace Problem_144
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

    // 144. Binary Tree Preorder Traversal
    // https://leetcode.com/problems/binary-tree-preorder-traversal/
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static IList<int> PreorderTraversal(TreeNode root)
        {
            if (root == null)
                return new List<int>();

            List<int> list = new List<int>();

            list.Add(root.val);
            list.AddRange(PreorderTraversal(root.left));
            list.AddRange(PreorderTraversal(root.right));

            return list;
        }
    }
}
