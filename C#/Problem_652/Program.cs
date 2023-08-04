using System.Collections.Generic;

namespace Problem_652
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

    // 652. Find Duplicate Subtrees
    // https://leetcode.com/problems/find-duplicate-subtrees/
    internal class Program
    {
        public IList<TreeNode> FindDuplicateSubtrees(TreeNode root)
        {
            List<TreeNode> d = new List<TreeNode>();
            return d;
        }

        static void Main(string[] args)
        {
        }
    }
}
