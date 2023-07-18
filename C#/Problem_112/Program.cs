namespace Problem_112
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

    // 112. Path Sum
    // https://leetcode.com/problems/path-sum/
    internal class Program
    {
        public static bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null)
                return false;
            else if (root.val == targetSum)
                return true;
            else if (root.val > targetSum)
                return false;
            else
                return PathSum(root, 0, targetSum);
        }

        static void Main(string[] args)
        {
            TreeNode left = new TreeNode(4, new TreeNode(11, new TreeNode(7), new TreeNode(2)));
            TreeNode right = new TreeNode(8, new TreeNode(13), new TreeNode(4, null, new TreeNode(1)));
            TreeNode root = new TreeNode(5, left, right);
            bool result = HasPathSum(root, 22);

            result = HasPathSum(new TreeNode(1, new TreeNode(2), new TreeNode(3)), 5);

            result = HasPathSum(null, 0);
        }

        public static bool PathSum(TreeNode root, int currentSum, int targetSum)
        {
            if (root == null)
                return false;

            currentSum += root.val;

            if (root.left == null && root.right == null)
                return targetSum == currentSum;

            return PathSum(root.left, currentSum, targetSum) || PathSum(root.right, currentSum, targetSum);
        }
    }
}
