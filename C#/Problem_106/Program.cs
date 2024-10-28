using System.Collections.Generic;
using LeetCode;

namespace Problem_106
{
    // 106. Construct Binary Tree from Inorder and Postorder Traversal
    // https://leetcode.com/problems/construct-binary-tree-from-inorder-and-postorder-traversal/
    internal class Program
    {
        public static TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            Dictionary<int, int> inOrderMap = new Dictionary<int, int>();
            for (int i = 0; i < inorder.Length; i++)
            {
                inOrderMap.Add(inorder[i], i);
            }

            int postOrderIndex = postorder.Length - 1;
            return BuildTreeNode(inOrderMap, postorder, ref postOrderIndex, 0, inorder.Length - 1);
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
            int[] inorder1 = new int[] { 9, 3, 15, 20, 7 };
            int[] postorder1 = new int[] { 9, 15, 7, 20, 3 };
            TreeNode root1 = BuildTree(inorder1, postorder1);

            int[] inorder2 = new int[] { -1 };
            int[] postorder2 = new int[] { -1 };
            TreeNode root2 = BuildTree(inorder2, postorder2);
        }
    }
}
