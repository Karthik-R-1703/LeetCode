using System.Collections.Generic;
using LeetCode;

namespace Problem_257
{
    // 257. Binary Tree Paths
    // https://leetcode.com/problems/binary-tree-paths/description/
    internal class Program
    {
        public static IList<string> BinaryTreePaths(TreeNode root)
        {
            List<string> paths = new List<string>();
            Traverse(root, string.Empty, paths);
            return paths;
        }

        private static void Traverse(TreeNode root, string path, List<string> paths)
        {
            if (root.left == null && root.right == null)
                paths.Add(path + root.val.ToString());

            if (root.left != null)
                Traverse(root.left, path + root.val.ToString() + "->", paths);

            if (root.right != null)
                Traverse(root.right, path + root.val.ToString() + "->", paths);
        }

        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1)
            {
                left = new TreeNode(2, null, new TreeNode(5)),
                right = new TreeNode(3)
            };

            BinaryTreePaths(root);
        }
    }
}
