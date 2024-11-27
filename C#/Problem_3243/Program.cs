using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3243
{
    // 3243. Shortest Distance After Road Addition Queries I
    // https://leetcode.com/problems/shortest-distance-after-road-addition-queries-i/description/

    public class Node
    {
        public int Value;

        public List<Node> Parents;

        public Node(int value, Node parent)
        {
            this.Value = value;
            this.Parents = new List<Node> { parent };
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] queries1 = new int[][] {
                new int[] { 2, 4 },
                new int[] { 0, 2 },
                new int[] { 0, 4 }
            };

            ShortestDistanceAfterQueries(5, queries1);
        }

        public static int[] ShortestDistanceAfterQueries(int n, int[][] queries)
        {
            Node prevNode = null;
            Dictionary<int, Node> nodes = new Dictionary<int, Node>();
            for (int i = 0; i < n; i++)
            {
                Node node = new Node(i, prevNode);
                prevNode = node;
                nodes.Add(i, node);
            }

            for (int i = 0; i < queries.Length; i++)
            {
                int u = queries[i][0];
                int v = queries[i][1];
                nodes[v].Parents.Add(nodes[u]);
            }

            int[] shortestPaths = new int[queries.Length];
            return shortestPaths;
        }
    }
}
