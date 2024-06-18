using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1122
{
    // 1122. Relative Sort Array
    // https://leetcode.com/problems/relative-sort-array/description/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1_1 = { 2, 3, 1, 3, 2, 4, 6, 7, 9, 2, 19 };
            int[] arr2_1 = { 2, 1, 4, 3, 9, 6 };
            RelativeSortArray(arr1_1, arr2_1);
        }

        public static int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            List<int> RelativeSortedArray = new List<int>();
            List<int> missedItems = new List<int>();
            Dictionary<int, int> map = new Dictionary<int, int>();
            foreach (int i in arr1)
            {
                if (map.ContainsKey(i))
                {
                    map[i]++;
                }
                else
                {
                    map.Add(i, 1);
                }

                if (!arr2.Contains(i))
                {
                    missedItems.Add(i);
                    int key = Array.IndexOf(arr1, i);
                }
            }

            foreach (int i in arr2)
            {
                for (int j = 0; j < map[i]; j++)
                {
                    RelativeSortedArray.Add(i);
                }
            }

            missedItems.Sort();
            RelativeSortedArray.AddRange(missedItems);
            return RelativeSortedArray.ToArray();
        }
    }
}
