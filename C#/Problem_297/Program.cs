using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_297
{
    // Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class Codec
    {
        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            StringBuilder sb = new StringBuilder();
            SerializeHelper(root, sb);
            return sb.ToString();
        }

        private void SerializeHelper(TreeNode node, StringBuilder sb)
        {
            if (node == null)
            {
                sb.Append("null,");
            }
            else
            {
                sb.Append(node.val + ",");
                SerializeHelper(node.left, sb);
                SerializeHelper(node.right, sb);
            }
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            Queue<string> nodes = new Queue<string>(data.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries));
            return DeserializeHelper(nodes);
        }

        private TreeNode DeserializeHelper(Queue<string> nodes)
        {
            string val = nodes.Dequeue();
            if (val == "null")
            {
                return null;
            }
            else
            {
                TreeNode node = new TreeNode(int.Parse(val));
                node.left = DeserializeHelper(nodes);
                node.right = DeserializeHelper(nodes);
                return node;
            }
        }
    }

    // Your Codec object will be instantiated and called as such:
    // Codec ser = new Codec();
    // Codec deser = new Codec();
    // TreeNode ans = deser.deserialize(ser.serialize(root));

    // 297. Serialize and Deserialize Binary Tree
    // https://leetcode.com/problems/serialize-and-deserialize-binary-tree/
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.right.left = new TreeNode(4);
            root.right.right = new TreeNode(5);

            Codec ser = new Codec();
            string serializedTree = ser.serialize(root);
        }
    }
}
