﻿using System;
using LeetCode;

namespace Problem_110
{
    // 110. Balanced Binary Tree
    // https://leetcode.com/problems/balanced-binary-tree/
    internal class Program
    {
        public static bool IsBalanced(TreeNode root)
        {
            if (root == null)
                return false;

            if (Math.Abs(Depth(root.left) - Depth(root.right)) <= 1)
                return true && IsBalanced(root.left) && IsBalanced(root.right);
            else
                return false;
        }

        public static int Depth(TreeNode root)
        {
            if (root == null)
                return 0;

            return Math.Max(Depth(root.left), Depth(root.right)) + 1;
        }

        static void Main(string[] args)
        {
        }
    }
}
