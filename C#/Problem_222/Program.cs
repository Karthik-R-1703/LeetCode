using LeetCode;

namespace Problem_222
{
    // 222. Count Complete Tree Nodes
    // https://leetcode.com/problems/count-complete-tree-nodes/description/
    internal class Program
    {
        private static int TotalCount = 0;

        private static void Count(TreeNode root)
        {
            if (root == null)
                return;

            Count(root.left);
            Count(root.right);
            TotalCount++;
        }

        public static int CountNodes(TreeNode root)
        {
            TotalCount = 0;
            Count(root);
            return TotalCount;
        }

        static void Main(string[] args)
        {
        }
    }
}
