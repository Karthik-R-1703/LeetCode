using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_100085
{
    // 100085. Minimum Processing Time
    internal class Program
    {
        static void Main(string[] args)
        {
            MinProcessingTime(new List<int> { 8, 10 }, new List<int> { 2, 2, 3, 1, 8, 7, 4, 5 });
            MinProcessingTime(new List<int> { 10, 20 }, new List<int> { 2, 3, 1, 2, 5, 8, 4, 3 });
        }

        public static int MinProcessingTime(IList<int> processorTime, IList<int> tasks)
        {
            int[] processorTimeArray = processorTime.ToArray();
            int[] tasksArray = tasks.ToArray();

            Array.Sort(processorTimeArray);
            Array.Sort(tasksArray);

            List<int> result = new List<int>();
            for (int i = 0; i < processorTimeArray.Length; i++)
            {
                int t = (processorTimeArray.Length - i) * 4;
                result.Add(Math.Max(Math.Max(processorTimeArray[i] + tasksArray[t - 1], processorTimeArray[i] + tasksArray[t - 2]), Math.Max(processorTimeArray[i] + tasksArray[t - 3], processorTimeArray[i] + tasksArray[t - 4])));
            }

            return result.Max();
        }
    }
}
