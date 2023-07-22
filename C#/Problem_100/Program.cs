namespace Problem_100
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

    // 100. Same Tree
    // https://leetcode.com/problems/same-tree/
    internal class Program
    {
        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
                return true;
            else if (p == null || q == null)
                return false;

            bool left = IsSameTree(p.left, q.left);

            if (!left)
                return false;

            bool right = IsSameTree(p.right, q.right);

            if (!right)
                return false;

            if (p.val != q.val)
                return false;

            return true;
        }

        static void Main(string[] args)
        {
            TreeNode T1_1 = new TreeNode(1, new TreeNode(2), new TreeNode(3));
            TreeNode T1_2 = new TreeNode(1, new TreeNode(2), new TreeNode(3));
            bool ret1 = IsSameTree(T1_1, T1_2);

            TreeNode T2_1 = new TreeNode(1, new TreeNode(2));
            TreeNode T2_2 = new TreeNode(1, null, new TreeNode(3));
            bool ret2 = IsSameTree(T2_1, T2_2);

            TreeNode T3_1 = new TreeNode(1, new TreeNode(2), new TreeNode(1));
            TreeNode T3_2 = new TreeNode(1, new TreeNode(1), new TreeNode(2));
            bool ret3 = IsSameTree(T3_1, T3_2);
        }
    }
}
