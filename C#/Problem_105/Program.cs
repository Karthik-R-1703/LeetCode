using System.Collections.Generic;
using LeetCode;

namespace Problem_105
{
    // 105. Construct Binary Tree from Preorder and Inorder Traversal
    // https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/
    internal class Program
    {
        public static TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            Dictionary<int, int> inOrderMap = new Dictionary<int, int>();
            for (int i = 0; i < inorder.Length; i++)
            {
                inOrderMap.Add(inorder[i], i);
            }

            int preOrderIndex = 0;
            return BuildTreeNode(inOrderMap, preorder, ref preOrderIndex, 0, inorder.Length - 1);
        }

        public static TreeNode BuildTreeNode(Dictionary<int, int> inOrderMap, int[] preOrder, ref int preOrderIndex, int leftIndex, int rightIndex)
        {
            if (leftIndex > rightIndex)
            {
                return null;
            }

            int root_val = preOrder[preOrderIndex];
            TreeNode root = new TreeNode(root_val);
            preOrderIndex++;

            int Index = inOrderMap[root_val];
            root.left = BuildTreeNode(inOrderMap, preOrder, ref preOrderIndex, leftIndex, Index - 1);
            root.right = BuildTreeNode(inOrderMap, preOrder, ref preOrderIndex, Index + 1, rightIndex);
            return root;
        }

        static void Main(string[] args)
        {
            int[] preorder1 = new int[] { 3, 9, 20, 15, 7 };
            int[] inorder1 = new int[] { 9, 3, 15, 20, 7 };
            TreeNode root1 = BuildTree(preorder1, inorder1);

            int[] preorder2 = new int[] { -1 };
            int[] inorder2 = new int[] { -1 };
            TreeNode root2 = BuildTree(preorder2, inorder2);
        }
    }
}
