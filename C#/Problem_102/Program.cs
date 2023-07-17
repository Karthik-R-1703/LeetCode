using System.Collections.Generic;

namespace Problem_102
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

    // 102. Binary Tree Level Order Traversal
    // https://leetcode.com/problems/binary-tree-level-order-traversal/
    internal class Program
    {
        public static Queue<TreeNode> GetLevel(Queue<TreeNode> levelQ, out List<int> level)
        {
            Queue<TreeNode> levelQ2 = new Queue<TreeNode>();
            level = new List<int>();

            while (levelQ.Count > 0)
            {
                TreeNode t1 = levelQ.Dequeue();
                level.Add(t1.val);

                if (t1.left != null)
                    levelQ2.Enqueue(t1.left);

                if (t1.right != null)
                    levelQ2.Enqueue(t1.right);
            }

            return levelQ2;
        }

        public static IList<IList<int>> LevelOrder(TreeNode root)
        {
            List<IList<int>> LevelValues = new List<IList<int>>();

            if (root == null)
                return LevelValues;

            Queue<TreeNode> levelQ = new Queue<TreeNode>();
            levelQ.Enqueue(root);

            Queue<TreeNode> levelQ2 = new Queue<TreeNode>();
            while (levelQ.Count > 0)
            {
                List<int> level = new List<int>();
                levelQ = GetLevel(levelQ, out level);
                if (level.Count > 0)
                {
                    LevelValues.Add(level);
                }
            }

            return LevelValues;
        }

        static void Main(string[] args)
        {
            TreeNode right = new TreeNode(20, new TreeNode(15), new TreeNode(7));
            TreeNode root = new TreeNode(3, new TreeNode(9), right);
            LevelOrder(root);
        }
    }
}
