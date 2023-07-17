namespace Problem_101
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

    // 101. Symmetric Tree
    // https://leetcode.com/problems/symmetric-tree/
    internal class Program
    {
        public static bool CheckSymmetry(TreeNode left, TreeNode right)
        {
            if (left == null && right == null)
                return true;

            if (left == null || right == null)
                return false;

            if (left.val != right.val)
                return false;

            return CheckSymmetry(left.left, right.right) && CheckSymmetry(left.right, right.left);
        }

        public static bool IsSymmetric(TreeNode root)
        {
            return CheckSymmetry(root.left, root.right);
        }

        static void Main(string[] args)
        {
            TreeNode left = new TreeNode(2, new TreeNode(3), new TreeNode(4));
            TreeNode right = new TreeNode(2, new TreeNode(4), new TreeNode(3));
            TreeNode root = new TreeNode(1, left, right);
            IsSymmetric(root);

            IsSymmetric(new TreeNode(1, new TreeNode(2, null, new TreeNode(3)), new TreeNode(2, null, new TreeNode(3))));
        }
    }
}
