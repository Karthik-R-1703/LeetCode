namespace Problem_1379
{
    // Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    // 1379. Find a Corresponding Node of a Binary Tree in a Clone of That Tree
    // https://leetcode.com/problems/find-a-corresponding-node-of-a-binary-tree-in-a-clone-of-that-tree/
    internal class Program
    {
        public static TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
        {
            if (original.val == target.val)
            {
                return cloned;
            }

            if (original.left != null)
            {
                TreeNode answer = GetTargetCopy(original.left, cloned.left, target);
                if (answer != null && answer.val == target.val)
                {
                    return answer;
                }
            }

            if (original.right != null)
            {
                TreeNode answer = GetTargetCopy(original.right, cloned.right, target);
                if (answer != null && answer.val == target.val)
                {
                    return answer;
                }
            }

            return null;
        }

        static void Main(string[] args)
        {
            TreeNode root1 = new TreeNode(7);
            root1.left = new TreeNode(4);
            root1.right = new TreeNode(3);
            root1.right.left = new TreeNode(6);
            root1.right.right = new TreeNode(19);
            TreeNode answer1 = GetTargetCopy(root1, root1, new TreeNode(3));

            TreeNode answer2 = GetTargetCopy(new TreeNode(7), new TreeNode(7), new TreeNode(7));

            TreeNode root2 = new TreeNode(8);
            root2.right = new TreeNode(6);
            root2.right.right = new TreeNode(5);
            root2.right.right.right = new TreeNode(4);
            root2.right.right.right.right = new TreeNode(3);
            root2.right.right.right.right.right = new TreeNode(2);
            root2.right.right.right.right.right.right = new TreeNode(1);
            TreeNode answer3 = GetTargetCopy(root2, root2, new TreeNode(4));
        }
    }
}
