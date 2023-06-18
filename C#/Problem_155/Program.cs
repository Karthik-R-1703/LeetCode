using System.Collections.Generic;
using System.Linq;

namespace Problem_155
{
    public class MinStack
    {
        Stack<int> node = new Stack<int>();

        public MinStack()
        {

        }

        public void Push(int val)
        {
            node.Push(val);
        }

        public void Pop()
        {
            node.Pop();
        }

        public int Top()
        {
            return node.Peek();
        }

        public int GetMin()
        {
            return node.Min();
        }
    }

    /**
     * Your MinStack object will be instantiated and called as such:
     * MinStack obj = new MinStack();
     * obj.Push(val);
     * obj.Pop();
     * int param_3 = obj.Top();
     * int param_4 = obj.GetMin();
     */

    // 155. Min Stack
    // https://leetcode.com/problems/min-stack/
    internal class Program
    {
        static void Main(string[] args)
        {
            MinStack obj = new MinStack();
            obj.Push(1);
            obj.Pop();
            int param_3 = obj.Top();
            int param_4 = obj.GetMin();
        }
    }
}
