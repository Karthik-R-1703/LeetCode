using System.Collections.Generic;
using LeetCode;

namespace Problem_652
{
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
