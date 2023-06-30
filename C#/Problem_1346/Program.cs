using System.Collections.Generic;

namespace Problem_1346
{
    // 1346. Check If N and Its Double Exist
    // https://leetcode.com/problems/check-if-n-and-its-double-exist/
    internal class Program
    {
        public static bool CheckIfExist(int[] arr)
        {
            bool isExist = false;

            HashSet<int> set = new HashSet<int>();

            foreach (int num in arr)
            {
                int t_num = 2 * num;
                if (set.Contains(t_num))
                {
                    isExist = true;
                    break;
                }

                if (num % 2 == 0)
                {
                    if (set.Contains(num / 2))
                    {
                        isExist = true;
                        break;
                    }
                }

                set.Add(num);
            }

            return isExist;
        }

        static void Main(string[] args)
        {
            List<int> arr;
            arr = new List<int>() { 10, 2, 5, 3 };
            CheckIfExist(arr.ToArray());

            arr = new List<int>() { 3, 1, 7, 11 };
            CheckIfExist(arr.ToArray());
        }
    }
}
