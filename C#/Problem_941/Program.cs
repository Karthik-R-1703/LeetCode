using System.Collections.Generic;

namespace Problem_941
{
    // 941. Valid Mountain Array
    // https://leetcode.com/problems/valid-mountain-array/
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> arr;

            arr = new List<int>() { 2, 1 };
            ValidMountainArray(arr.ToArray());

            arr = new List<int>() { 3, 5, 5 };
            ValidMountainArray(arr.ToArray());

            arr = new List<int>() { 0, 3, 2, 1 };
            ValidMountainArray(arr.ToArray());
        }

        public static bool ValidMountainArray(int[] arr)
        {
            bool isValid = true;
            int isIncreasing = 0;
            bool isDecreasing = false;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (isIncreasing >= 0)
                {
                    if (arr[i] < arr[i + 1])
                    {
                        isIncreasing++;
                    }
                    else if (arr[i] == arr[i + 1])
                    {
                        isValid = false;
                        break;
                    }
                    else
                    {
                        if (isIncreasing > 0)
                        {
                            isIncreasing = -1;
                            isDecreasing = true;
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }
                    }
                }

                if (isDecreasing)
                {
                    if (arr[i] > arr[i + 1])
                    {
                    }
                    else
                    {
                        isValid = false;
                        break;
                    }
                }
            }

            if (!isDecreasing)
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
