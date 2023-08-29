using System.Collections.Generic;

namespace Problem_225
{
    public class MyStack
    {
        Queue<int> stack;

        public MyStack()
        {
            stack = new Queue<int>();
        }

        public void Push(int x)
        {
            stack.Enqueue(x);
            int count = stack.Count;
            while (count > 1)
            {
                stack.Enqueue(stack.Dequeue());
                count--;
            }
        }

        public int Pop()
        {
            return stack.Dequeue();
        }

        public int Top()
        {
            return stack.Peek();
        }

        public bool Empty()
        {
            return stack.Count == 0;
        }
    }

    /**
     * Your MyStack object will be instantiated and called as such:
     * MyStack obj = new MyStack();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Top();
     * bool param_4 = obj.Empty();
     */

    // 225. Implement Stack using Queues
    // https://leetcode.com/problems/implement-stack-using-queues/
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack myStack = new MyStack();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Top(); // return 2
            myStack.Pop(); // return 2
            myStack.Empty(); // return False
        }
    }
}
