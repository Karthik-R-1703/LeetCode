using System.Collections.Generic;

namespace Problem_3243
{
    // 3243. Shortest Distance After Road Addition Queries I
    // https://leetcode.com/problems/shortest-distance-after-road-addition-queries-i/description/

    public class Node
    {
        public int Value;

        public List<Node> Children;

        public Node(int value, Node child = null)
        {
            Value = value;
            if (child != null)
                Children = new List<Node> { child };
            else
                Children = new List<Node>();
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

        private static int NodeSearch(int n, Dictionary<int, Node> Nodes)
        {
            Queue<Node> CurrentLayer = new Queue<Node>();
            CurrentLayer.Enqueue(Nodes[0]);
            int length = 0;
            List<Node> visitedNodes = new List<Node>
            {
                Nodes[0]
            };

            while (CurrentLayer.Count > 0)
            {
                length++;
                Queue<Node> NextLayer = new Queue<Node>();
                while (CurrentLayer.Count > 0)
                {
                    Node node = CurrentLayer.Dequeue();
                    foreach (Node child in node.Children)
                    {
                        if (child.Value == n - 1)
                            return length;

                        if (visitedNodes.Contains(child))
                            continue;
                        else
                            visitedNodes.Add(child);

                        NextLayer.Enqueue(child);
                    }
                }

                CurrentLayer = NextLayer;
            }

            return length;
        }

        public static int[] ShortestDistanceAfterQueries(int n, int[][] queries)
        {
            Node childNode = null;
            Dictionary<int, Node> nodes = new Dictionary<int, Node>();
            for (int i = n - 1; i >= 0; i--)
            {
                Node node = new Node(i, childNode);
                childNode = node;
                nodes.Add(i, node);
            }

            int[] shortestPaths = new int[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                int u = queries[i][0];
                int v = queries[i][1];
                nodes[u].Children.Add(nodes[v]);
                shortestPaths[i] = NodeSearch(n, nodes);
            }

            return shortestPaths;
        }
    }
}
