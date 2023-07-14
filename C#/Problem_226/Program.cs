namespace Problem_226
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

    // 226. Invert Binary Tree
    // https://leetcode.com/problems/invert-binary-tree/
    internal class Program
    {
        public static TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return null;

            InvertTree(root.left);
            InvertTree(root.right);

            TreeNode temp = root.left;
            root.left = root.right;
            root.right = temp;

            return root;
        }

        static void Main(string[] args)
        {
            TreeNode left = new TreeNode(2, new TreeNode(1), new TreeNode(3));
            TreeNode right = new TreeNode(7, new TreeNode(6), new TreeNode(9));
            TreeNode root = new TreeNode(4, left, right);
            InvertTree(root);
            InvertTree(left);
            InvertTree(null);
        }
    }
}
