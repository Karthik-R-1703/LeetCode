using LeetCode;

namespace Problem_938
{
    // 938. Range Sum of BST
    // https://leetcode.com/problems/range-sum-of-bst/description/
    internal class Program
    {
        public static int sum = 0;

        static void Main(string[] args)
        {
            TreeNode treeNode1 = new TreeNode(10, new TreeNode(5, new TreeNode(3), new TreeNode(7)), new TreeNode(15, null, new TreeNode(18)));
            RangeSumBST(treeNode1, 7, 15);

            TreeNode treeNode2 = new TreeNode(10, new TreeNode(5, new TreeNode(3, new TreeNode(1)), new TreeNode(7, new TreeNode(6))), new TreeNode(15, new TreeNode(13), new TreeNode(18)));
            RangeSumBST(treeNode2, 7, 15);
        }

        public static void RangeSum(TreeNode root, int low, int high)
        {
            if (root != null)
                return;

            if (low <= root.val && root.val <= high)
                sum += root.val;

            RangeSum(root.left, low, high);
            RangeSum(root.right, low, high);
        }

        public static int RangeSumBST(TreeNode root, int low, int high)
        {
            sum = 0;
            RangeSum(root, low, high);
            return sum;
        }
    }
}
