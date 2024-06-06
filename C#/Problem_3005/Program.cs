using System.Collections.Generic;

namespace Problem_3005
{
    // 3005. Count Elements With Maximum Frequency
    // https://leetcode.com/problems/count-elements-with-maximum-frequency/description/
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static int MaxFrequencyElements(int[] nums)
        {
            Dictionary<int, int> frequencies = new Dictionary<int, int>();
            int maxFrequency = 0;
            int totalFrequencies = 0;

            foreach (int num in nums)
            {
                if (frequencies.ContainsKey(num))
                    frequencies[num]++;
                else
                    frequencies.Add(num, 1);

                int frequency = frequencies[num];
                if (frequency > maxFrequency)
                {
                    maxFrequency = frequency;
                    totalFrequencies = frequency;
                }
                else if (frequency == maxFrequency)
                {
                    totalFrequencies += frequency;
                }
            }

            return totalFrequencies;
        }
    }
}
