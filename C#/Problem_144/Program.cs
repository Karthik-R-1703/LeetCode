using System.Collections.Generic;
using LeetCode;

namespace Problem_144
{
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
