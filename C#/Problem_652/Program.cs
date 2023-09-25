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
        public static List<TreeNode> DuplicateSubtrees(TreeNode root, List<TreeNode> subTrees)
        {
            List<TreeNode> result = new List<TreeNode>();
            if (root == null)
                return result;

            result.AddRange(DuplicateSubtrees(root.left, subTrees));
            result.AddRange(DuplicateSubtrees(root.right, subTrees));

            if (subTrees.Contains(root))
                result.Add(root);

            subTrees.Add(root);
            return result;
        }

        public static IList<TreeNode> FindDuplicateSubtrees(TreeNode root)
        {
            List<TreeNode> d = new List<TreeNode>();
            return DuplicateSubtrees(root, d);
        }

        static void Main(string[] args)
        {
        }
    }
}
