namespace Problem_106
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

    // 106. Construct Binary Tree from Inorder and Postorder Traversal
    // https://leetcode.com/problems/construct-binary-tree-from-inorder-and-postorder-traversal/
    internal class Program
    {
        public static TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            TreeNode root = new TreeNode();

            return root;
        }

        static void Main(string[] args)
        {
            int[] inorder1 = new int[] { 9, 3, 15, 20, 7 };
            int[] postorder1 = new int[] { 9, 15, 7, 20, 3 };
            BuildTree(inorder1, postorder1);

            int[] inorder2 = new int[] { -1 };
            int[] postorder2 = new int[] { -1 };
            BuildTree(inorder2, postorder2);
        }
    }
}
