using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Problem_752
{
    // 752. Open the Lock
    // https://leetcode.com/problems/open-the-lock/
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] deadends1 = { "0201", "0101", "0102", "1212", "2002" };
            OpenLock(deadends1, "0202");

            string[] deadends2 = { "8888" };
            OpenLock(deadends2, "0009");

            string[] deadends3 = { "8887", "8889", "8878", "8898", "8788", "8988", "7888", "9888" };
            OpenLock(deadends3, "8888");
        }

        public static int OpenLock(string[] deadends, string target)
        {
            string start = "0000";
            if (start == target)
                return 0;

            if (deadends.Contains(start))
                return -1;

            Queue<string> queue = new Queue<string>();
            queue.Enqueue(start);

            HashSet<string> visited = new HashSet<string>();
            visited.Add(start);

            int turns = 0;
            while (queue.Count > 0)
            {
                string cur_lock = queue.Dequeue();
                for (int i = 0; i < 4; i++)
                {
                    for (int j = -1; j <= 1; j += 2)
                    {
                        int digit = cur_lock[i] - '0';
                        int newDigit = (digit + j + 10) % 10;
                        string new_lock = cur_lock.Substring(0, i) + newDigit + cur_lock.Substring(i + 1);

                        if (new_lock == target)
                        {
                            return turns + 1;
                        }

                        if (!deadends.Contains(new_lock) && !visited.Contains(new_lock))
                        {
                            queue.Enqueue(new_lock);
                            visited.Add(new_lock);
                            turns++;
                        }
                    }
                }
            }

            return turns;
        }
    }
}
