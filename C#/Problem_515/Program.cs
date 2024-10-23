using System.Collections.Generic;

namespace Problem_515
{
    // 515. Find Largest Value in Each Tree Row
    // https://leetcode.com/problems/find-largest-value-in-each-tree-row/description/
    internal class Program
    {
        public static IList<int> LargestValues(TreeNode root)
        {
            List<int> result = new List<int>();
            if (root == null)
                return result;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int max = int.MinValue;
                Queue<TreeNode> level = new Queue<TreeNode>();
                while (queue.Count > 0)
                {
                    TreeNode node = queue.Dequeue();
                    if (node.val > max)
                        max = node.val;

                    if (node.left != null)
                        level.Enqueue(node.left);

                    if (node.right != null)
                        level.Enqueue(node.right);
                }

                result.Add(max);
                if (level.Count > 0)
                    queue = level;
            }

            return result;
        }

        static void Main(string[] args)
        {
        }
    }

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
}
