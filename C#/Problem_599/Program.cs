using System.Collections.Generic;
using System.Linq;

namespace Problem_599
{
    // 599. Minimum Index Sum of Two Lists
    // https://leetcode.com/problems/minimum-index-sum-of-two-lists/
    internal class Program
    {
        public static string[] FindRestaurant(string[] list1, string[] list2)
        {
            List<string> list_1 = list1.ToList();
            List<string> list_2 = list2.ToList();
            Dictionary<int, List<string>> result = new Dictionary<int, List<string>>();

            for (int i1 = 0; i1 < list_1.Count; i1++)
            {
                int i2 = list_2.IndexOf(list_1[i1]);
                if (i2 >= 0)
                {
                    if (result.ContainsKey(i1 + i2))
                        result[i1 + i2].Add(list_1[i1]);
                    else
                        result.Add(i1 + i2, new List<string> { list_1[i1] });
                }
            }

            return result[result.Keys.Min()].ToArray();
        }

        static void Main(string[] args)
        {
            List<string> list1;
            List<string> list2;

            list1 = new List<string>() { "Shogun", "Tapioca Express", "Burger King", "KFC" };
            list2 = new List<string>() { "Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun" };
            FindRestaurant(list1.ToArray(), list2.ToArray());

            list1 = new List<string>() { "Shogun", "Tapioca Express", "Burger King", "KFC" };
            list2 = new List<string>() { "KFC", "Shogun", "Burger King" };
            FindRestaurant(list1.ToArray(), list2.ToArray());

            list1 = new List<string>() { "happy", "sad", "good" };
            list2 = new List<string>() { "sad", "happy", "good" };
            FindRestaurant(list1.ToArray(), list2.ToArray());
        }
    }
}
