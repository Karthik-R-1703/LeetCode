using System.Collections.Generic;
using LeetCode;

namespace Problem_1302
{
    // 1302. Deepest Leaves Sum
    // https://leetcode.com/problems/deepest-leaves-sum/description/
    internal class Program
    {
        public static int DeepestLeavesSum(TreeNode root)
        {
            int preSum = root.val;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int sum = 0;
                Queue<TreeNode> level = new Queue<TreeNode>();
                while (queue.Count > 0)
                {
                    TreeNode node = queue.Dequeue();

                    if (node.left != null)
                    {
                        sum += node.left.val;
                        level.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        sum += node.right.val;
                        level.Enqueue(node.right);
                    }
                }

                if (level.Count > 0)
                {
                    preSum = sum;
                    queue = level;
                }
            }

            return preSum;
        }

        static void Main(string[] args)
        {
        }
    }
}
