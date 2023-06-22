using System;

namespace Problem_1299
{
    // 1299. Replace Elements with Greatest Element on Right Side
    // https://leetcode.com/problems/replace-elements-with-greatest-element-on-right-side/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 17, 18, 5, 4, 6, 1 };
            ReplaceElements(arr1);

            int[] arr2 = { 400 };
            ReplaceElements(arr2);
        }

        public static int[] ReplaceElements(int[] arr)
        {
            int[] elements = new int[arr.Length];

            elements[arr.Length - 1] = -1;

            for (int i = arr.Length - 1; i > 0; i--)
            {
                elements[i - 1] = Math.Max(elements[i], arr[i]);
            }

            return elements;
        }
    }
}
