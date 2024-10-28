using System.Collections.Generic;
using LeetCode;

namespace Problem_1038
{
    // 1038. Binary Search Tree to Greater Sum Tree
    // https://leetcode.com/problems/binary-search-tree-to-greater-sum-tree/description/
    internal class Program
    {
        public static TreeNode BstToGst(TreeNode root)
        {
            int sum = 0;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode treeNode = root;
            while (stack.Count > 0 || treeNode != null)
            {
                while (treeNode != null)
                {
                    stack.Push(treeNode);
                    treeNode = treeNode.right;
                }

                treeNode = stack.Pop();
                sum += treeNode.val;
                treeNode.val = sum;
                treeNode = treeNode.left;
            }

            return root;
        }

        static void Main(string[] args)
        {
            TreeNode TreeNode1 = new TreeNode(4, new TreeNode(1, new TreeNode(0), new TreeNode(2, null, new TreeNode(3))), new TreeNode(6, new TreeNode(5), new TreeNode(7, null, new TreeNode(8))));
            TreeNode1 = BstToGst(TreeNode1);

            TreeNode TreeNode2 = new TreeNode(0, null, new TreeNode(1));
            TreeNode2 = BstToGst(TreeNode2);
        }
    }
}
