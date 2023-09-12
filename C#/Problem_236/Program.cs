using System.Collections.Generic;

namespace Problem_236
{
    // Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    // 236. Lowest Common Ancestor of a Binary Tree
    // https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree/
    internal class Program
    {
        public static bool FindTrace(TreeNode root, TreeNode target, Stack<TreeNode> tree)
        {
            if (root == null)
                return false;

            tree.Push(root);

            if (root == target)
                return true;

            if (FindTrace(root.left, target, tree) || FindTrace(root.right, target, tree))
                return true;

            tree.Pop();
            return false;
        }

        public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            Stack<TreeNode> pTree = new Stack<TreeNode>();
            FindTrace(root, p, pTree);

            Stack<TreeNode> qTree = new Stack<TreeNode>();
            FindTrace(root, q, qTree);

            while (pTree.Count > 0)
            {
                TreeNode pNode = pTree.Pop();
                if (qTree.Contains(pNode))
                    return pNode;
            }

            return root;
        }

        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(5);
            root.right = new TreeNode(1);
            root.left.left = new TreeNode(6);
            root.left.right = new TreeNode(2);
            root.right.left = new TreeNode(0);
            root.right.right = new TreeNode(8);
            root.left.right.left = new TreeNode(7);
            root.left.right.right = new TreeNode(4);

            TreeNode p = root.left;
            TreeNode q = root.right;
            LowestCommonAncestor(root, p, q);
        }
    }
}
