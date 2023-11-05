using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1361
{
    // 1361. Validate Binary Tree Nodes
    // https://leetcode.com/problems/validate-binary-tree-nodes/description/
    internal class Program
    {
        static void Main(string[] args)
        {
            ValidateBinaryTreeNodes(4, new int[] { 1, -1, 3, -1 }, new int[] { 2, -1, -1, -1 });
            ValidateBinaryTreeNodes(4, new int[] { 1, -1, 3, -1 }, new int[] { 2, 3, -1, -1 });
            ValidateBinaryTreeNodes(2, new int[] { 1, 0 }, new int[] { -1, -1 });
        }
        public static bool ValidateBinaryTreeNodes(int n, int[] leftChild, int[] rightChild)
        {
            return true;
        }
    }
}
