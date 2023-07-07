using System.Collections.Generic;
using System.Linq;

namespace Problem_622
{
    public class MyCircularQueue
    {
        Queue<int> queue = new Queue<int>();

        int Capacity = 0;

        public MyCircularQueue(int k)
        {
            Capacity = k;
            queue = new Queue<int>(k);
        }

        public bool EnQueue(int value)
        {
            if (queue.Count == Capacity)
                return false;
            else
            {
                queue.Enqueue(value);
                return true;
            }
        }

        public bool DeQueue()
        {
            if (queue.Count == 0)
                return false;
            else
            {
                queue.Dequeue();
                return true;
            }
        }

        public int Front()
        {
            if (queue.Count == 0)
                return -1;
            else
                return queue.First();
        }

        public int Rear()
        {
            if (queue.Count == 0)
                return -1;
            else
                return queue.Last();
        }

        public bool IsEmpty()
        {
            return queue.Count == 0;
        }

        public bool IsFull()
        {
            return queue.Count == Capacity;
        }
    }

    /**
     * Your MyCircularQueue object will be instantiated and called as such:
     * MyCircularQueue obj = new MyCircularQueue(k);
     * bool param_1 = obj.EnQueue(value);
     * bool param_2 = obj.DeQueue();
     * int param_3 = obj.Front();
     * int param_4 = obj.Rear();
     * bool param_5 = obj.IsEmpty();
     * bool param_6 = obj.IsFull();
     */

    // 622. Design Circular Queue
    // https://leetcode.com/problems/design-circular-queue/
    internal class Program
    {
        static void Main(string[] args)
        {
            MyCircularQueue myCircularQueue = new MyCircularQueue(3);
            myCircularQueue.EnQueue(1); // return True
            myCircularQueue.EnQueue(2); // return True
            myCircularQueue.EnQueue(3); // return True
            myCircularQueue.EnQueue(4); // return False
            myCircularQueue.Rear();     // return 3
            myCircularQueue.IsFull();   // return True
            myCircularQueue.DeQueue();  // return True
            myCircularQueue.EnQueue(4); // return True
            myCircularQueue.Rear();     // return 4
        }
    }
}
