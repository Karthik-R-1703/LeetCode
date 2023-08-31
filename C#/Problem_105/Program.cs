using System.Collections.Generic;

namespace Problem_105
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

    // 105. Construct Binary Tree from Preorder and Inorder Traversal
    // https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/
    internal class Program
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            Dictionary<int, int> preOrderMap = new Dictionary<int, int>();
            for (int i = 0; i < preorder.Length; i++)
            {
                preOrderMap.Add(preorder[i], i);
            }

            int inOrderIndex = 0;
            return BuildTreeNode(preOrderMap, inorder, ref inOrderIndex, 0, preorder.Length - 1);
        }

        public static TreeNode BuildTreeNode(Dictionary<int, int> inOrderMap, int[] postOrder, ref int postOrderIndex, int leftIndex, int rightIndex)
        {
            if (leftIndex > rightIndex)
            {
                return null;
            }

            int root_val = postOrder[postOrderIndex];
            TreeNode root = new TreeNode(root_val);
            postOrderIndex--;

            int Index = inOrderMap[root_val];
            root.right = BuildTreeNode(inOrderMap, postOrder, ref postOrderIndex, Index + 1, rightIndex);
            root.left = BuildTreeNode(inOrderMap, postOrder, ref postOrderIndex, leftIndex, Index - 1);
            return root;
        }

        static void Main(string[] args)
        {
        }
    }
}
