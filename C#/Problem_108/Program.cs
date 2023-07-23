using System;

namespace Problem_108
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

    // 108. Convert Sorted Array to Binary Search Tree
    // https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { -10, -3, 0, 5, 9 };
            TreeNode root1 = SortedArrayToBST(nums1);

            int[] nums2 = { 1, 3 };
            TreeNode root2 = SortedArrayToBST(nums2);
        }

        public static TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return null;

            int mid = nums.Length / 2;

            TreeNode root = new TreeNode(nums[mid]);

            int[] left = new int[mid];
            Array.Copy(nums, left, mid);
            root.left = SortedArrayToBST(left);

            int[] right = new int[nums.Length - 1 - mid];
            Array.Copy(nums, mid + 1, right, 0, nums.Length - 1 - mid);
            root.right = SortedArrayToBST(right);

            return root;
        }
    }
}
