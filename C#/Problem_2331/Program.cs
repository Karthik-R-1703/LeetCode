using LeetCode;

namespace Problem_2331
{
    // 2331. Evaluate Boolean Binary Tree
    // https://leetcode.com/problems/evaluate-boolean-binary-tree/description/
    internal class Program
    {
        public static bool EvaluateTree(TreeNode root)
        {
            if (root.left == null && root.right == null)
                return root.val == 1;

            bool left_result = EvaluateTree(root.left);
            bool right_result = EvaluateTree(root.right);

            bool result = false;
            if (root.val == 2)
                result = left_result || right_result;
            else
                result = left_result && right_result;

            return result;
        }

        static void Main(string[] args)
        {
        }
    }
}
